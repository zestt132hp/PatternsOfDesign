using System;
using System.IO;
using PatternsOfDesign.structure_patterns.Facade.Codecs;
using static System.BitConverter;

namespace PatternsOfDesign.structure_patterns.Facade
{
    class VideoConverter
    {
        public FileInfo Convert(string fileName, string format)
        {
            var file = new VideoFile(fileName);
            var extractFile = new CodecFactory().ExtractFile(file);
            FileInfo fileInfo = new FileInfo(fileName);
            byte[] buff = new byte[] { Buffer.GetByte(new char[] { }, 0) };
            var d = ToDouble(buff, 0);
            if (format == "mp4")
            {
                StreamWriter wr = StreamWriter.Null;
                wr.WriteLine(buff.ToString());
            }
            else
            {
                buff = new[] {Buffer.GetByte(new byte[] { }, 0)};
                StreamWriter wr = StreamWriter.Null;
                wr.WriteLine(buff.ToString());
            }
            return fileInfo;
        }
    }
}
