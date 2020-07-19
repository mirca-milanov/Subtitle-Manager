using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SubtitleManager
{
  public class SrtSubtitle : ISubtitle
  {

    public List<ISubtitleLine> Lines { get; set; } = new List<ISubtitleLine>();

    public SrtSubtitle() { }

    public SrtSubtitle(string subtitle)
    {
      string[] subtitleLines = Regex.Split(subtitle, @"^\s*$", RegexOptions.Multiline);

      foreach (string subtitleLine in subtitleLines)
      {
        string subtitleLineTrimmed = subtitleLine.Trim();
        SrtSubtitleLine block = new SrtSubtitleLine(subtitleLineTrimmed);
        Lines.Add(block);
      }
    }
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < Lines.Count; i++)
      {
        sb.Append(Lines[i].ToString());
        if (i + 1 < Lines.Count)
        {
          sb.AppendLine();
          sb.AppendLine();
        }
      }
      return sb.ToString();
    }
  }
}
