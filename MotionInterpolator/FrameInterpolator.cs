using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.FFMPEG;

namespace MotionInterpolator
{


    class FrameInterpolator
    {
        private string fileName;

        private VideoFileReader videoReader;
        private VideoFileWriter videoWriter;

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
    }

}
