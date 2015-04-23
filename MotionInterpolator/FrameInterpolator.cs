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

        private int multiplier;

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

        public void setMultiplier(int multiplier)
        {
            this.multiplier = multiplier;
        }

        public int getMultiplier() {
            return multiplier;
        }

        public void interpolateFrames(string fileName)
        {
            videoWriter = new VideoFileWriter();

            int targetFPS = getVideoFrameRate() * getMultiplier();

            videoWriter.Open(fileName, getVideoWidth(), getVideoHeight(), getVideoFrameRate() * 2, VideoCodec.MPEG4, 10000);

            Bitmap currentFrame;
            Bitmap nextFrame;
            Bitmap interpolatedFrame;

            currentFrame = videoReader.ReadVideoFrame();


            int width = getVideoWidth();
            int height = getVideoHeight();
            Rectangle rect = new Rectangle(0, 0, width, height);

            PixelFormat pixelFormat = currentFrame.PixelFormat;
            

            for (int i = 0; i < videoReader.FrameCount - 1; i++)
            {
                nextFrame = videoReader.ReadVideoFrame();

                sender.updatePreviewBox(currentFrame);
                videoWriter.WriteVideoFrame(currentFrame);
                
               
                unsafe
                {
                    
                    BitmapData currentFrameBmpData = currentFrame.LockBits(rect, ImageLockMode.ReadOnly, pixelFormat);

                    byte* currentFrameScan0 = (byte*) currentFrameBmpData.Scan0;

                    BitmapData nextFrameBmpData = nextFrame.LockBits(rect, ImageLockMode.ReadOnly, pixelFormat);

                    byte* nextFrameScan0 = (byte*) nextFrameBmpData.Scan0;

                    
                    int pixelSize = (pixelFormat == PixelFormat.Format8bppIndexed) ? 1 :
                    (pixelFormat == PixelFormat.Format24bppRgb) ? 3 : 4;


                    int lineSize = pixelSize * currentFrameBmpData.Width;

                    int currentFrameOffset = currentFrameBmpData.Stride - lineSize;
                    int nextFrameOffset = nextFrameBmpData.Stride - lineSize;

                    

                    byte* currentFramePtr = (byte*)currentFrameBmpData.Scan0;
                    byte* nextFramePtr = (byte*)nextFrameBmpData.Scan0;


                        
                    interpolatedFrame = new Bitmap(width, height, pixelFormat);

                    BitmapData interpolatedFrameBmpData = interpolatedFrame.LockBits(rect, ImageLockMode.ReadWrite, pixelFormat);

                    byte* interpolatedFramePtr = (byte*)interpolatedFrameBmpData.Scan0;


                    int interpolatedValue;

                    for (int y = 0; y < height; y++) 
                    {
                        for (int x = 0; x < lineSize; x++, currentFramePtr++, nextFramePtr++, interpolatedFramePtr++)
                        {
                            int currentFrameValue = *currentFramePtr;
                            int nextFrameValue = *nextFramePtr;

                            interpolatedValue = (byte)((currentFrameValue + nextFrameValue) / 2);
                            *interpolatedFramePtr = (interpolatedValue > 255) ? (byte)255 : (byte)interpolatedValue;
                        }
                    }

                    currentFramePtr += currentFrameOffset;
                    nextFramePtr += nextFrameOffset;


                    currentFramePtr = (byte*)currentFrameBmpData.Scan0;
                    nextFramePtr = (byte*)nextFrameBmpData.Scan0;


                    currentFrame.UnlockBits(currentFrameBmpData);

                    nextFrame.UnlockBits(nextFrameBmpData);

                    interpolatedFrame.UnlockBits(interpolatedFrameBmpData);

                    sender.updatePreviewBox(interpolatedFrame);

                    videoWriter.WriteVideoFrame(interpolatedFrame);

                    //interpolatedFrame.Dispose();


                    sender.updateCurrentFrameDisplay(i, (int)videoReader.FrameCount * multiplier);  

                    


                }
                
                currentFrame = nextFrame;


            }
            videoWriter.Close();

        }




    }

}
