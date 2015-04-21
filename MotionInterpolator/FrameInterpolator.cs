using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.FFMPEG;
using System.Drawing;
using System.Drawing.Imaging;

namespace MotionInterpolator
{


    class FrameInterpolator
    {
        private string fileName;

        private VideoFileReader videoReader;
        private VideoFileWriter videoWriter;

        MainForm sender;

        public FrameInterpolator()
        {

        }

        public FrameInterpolator(string fileName)
        {
            setFileName(fileName);
        }

        public void setFileName(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                fileName = name;
            }
        }

        public string getFileName()
        {
            return fileName;
        }

        public void loadReader()
        {
            videoReader = new VideoFileReader();
            videoReader.Open(getFileName());

        }

        public int getVideoHeight()
        {
            return videoReader.Height;
        }

        public int getVideoWidth()
        {
            return videoReader.Width;
        }

        public string getVideoCodec()
        {
            return videoReader.CodecName;
        }

        public int getVideoFrameRate() {
            return videoReader.FrameRate;
        }

        public void setSender(MainForm form)
        {
            sender = form;
        }

        public void interpolateFrames()
        {
            videoWriter = new VideoFileWriter();
            videoWriter.Open("test.avi", getVideoWidth(), getVideoHeight(), 10, VideoCodec.MPEG4, 10000);

            Bitmap currentFrame;
            Bitmap nextFrame;
            Bitmap interpolatedFrame;

            currentFrame = videoReader.ReadVideoFrame();

            Rectangle rect = new Rectangle(0, 0, getVideoWidth(), getVideoHeight());

            Console.WriteLine(videoReader.FrameCount);

            foreach (var prop in videoReader.GetType().GetProperties())
            {
                Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(videoReader, null));
            }

            for (int i = 0; i < videoReader.FrameCount - 1; i++)
            {

                interpolatedFrame = new Bitmap(getVideoWidth(), getVideoHeight());

                //Get the current frame's bitmap data
                /*
                BitmapData currentFrameBmpData = currentFrame.LockBits(rect, ImageLockMode.ReadOnly, currentFrame.PixelFormat);

                IntPtr currentFramePtr = currentFrameBmpData.Scan0;

                int currentFrameBytes = Math.Abs(currentFrameBmpData.Stride) * currentFrame.Height;

                byte[] currentFrameRGB = new byte[currentFrameBytes];

                System.Runtime.InteropServices.Marshal.Copy(currentFramePtr, currentFrameRGB, 0, currentFrameBytes);

                //Unlock the bitmap data in memory after we're done with it
                currentFrame.UnlockBits(currentFrameBmpData);
                */


                

                /*
                //Get the next frame's bitmap data
                BitmapData nextFrameBmpData = nextFrame.LockBits(rect, ImageLockMode.ReadOnly, nextFrame.PixelFormat);

                IntPtr nextFramePtr = nextFrameBmpData.Scan0;

                int nextFrameBytes = Math.Abs(nextFrameBmpData.Stride) * nextFrame.Height;

                byte[] nextFrameRGB = new byte[nextFrameBytes];

                System.Runtime.InteropServices.Marshal.Copy(nextFramePtr, nextFrameRGB, 0, nextFrameBytes);

                //Unlock the bitmap data
                nextFrame.UnlockBits(nextFrameBmpData);


                //byte[] interpolatedFrameRGB = currentFrameRGB.Zip(nextFrameRGB, (x, y) => (x + y));
                */



                nextFrame = videoReader.ReadVideoFrame();


                for (int x = 0; x < getVideoWidth(); x++)
                {
                    for (int y = 0; y < getVideoHeight(); y++)
                    {

                        Color curFrameColor = currentFrame.GetPixel(x, y);

                        Color nextFrameColor = nextFrame.GetPixel(x, y);

                        Color averageColor = Color.FromArgb((curFrameColor.R + nextFrameColor.R) / 2, (curFrameColor.G + nextFrameColor.G) / 2, (curFrameColor.B + nextFrameColor.B) / 2);

                        interpolatedFrame.SetPixel(x, y, averageColor);
                    }
                }

                sender.updateCurrentFrameDisplay(i, (int)videoReader.FrameCount);

                currentFrame = nextFrame;

                videoWriter.WriteVideoFrame(currentFrame);
                videoWriter.WriteVideoFrame(interpolatedFrame);

                interpolatedFrame.Dispose();

            }
            videoWriter.Close();

        }


    }

}
