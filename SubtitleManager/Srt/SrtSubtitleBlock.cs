using System;
using System.IO;

namespace SubtitleManager
{
    public class SrtSubtitleBlock : ISubtitleBlock
    {
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public string Text { get; set; }
        public int LineNumber { get; set; }
        public SrtSubtitleBlock()
        {

        }
        public SrtSubtitleBlock(string subtitleText)
        {
            using (StringReader data = new StringReader(subtitleText))
            {
                LineNumber = int.Parse(data.ReadLine().Trim());

                string secondLine = data.ReadLine();
                Start = TimeSpan.ParseExact(secondLine.Substring(0, 12),@"hh\:mm\:ss\,fff", null);
                End = TimeSpan.ParseExact(secondLine.Substring(17, 12),@"hh\:mm\:ss\,fff", null);

                Text = data.ReadToEnd();
            }
        }
    }
}
