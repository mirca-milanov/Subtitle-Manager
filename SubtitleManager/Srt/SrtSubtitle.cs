using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SubtitleManager
{
    public class SrtSubtitle : ISubtitle
    {
        public List<ISubtitleBlock> Subtitles { get; set; } = new List<ISubtitleBlock>();
        public SrtSubtitle()
        {

        }
        public SrtSubtitle(string subtitle)
        {
            string[] subtitleLines = Regex.Split(subtitle, @"^\s*$", RegexOptions.Multiline);
            foreach (string subtitleLine in subtitleLines)
            {
                string subtitleLineTrimmed = subtitleLine.Trim();
                SrtSubtitleBlock block = new SrtSubtitleBlock(subtitleLineTrimmed);
                Subtitles.Add(block);
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Subtitles.Count; i++)
            {
                sb.Append(Subtitles[i].ToString());
                if (i + 1 < Subtitles.Count)
                {
                    sb.AppendLine();
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }
    }
}
