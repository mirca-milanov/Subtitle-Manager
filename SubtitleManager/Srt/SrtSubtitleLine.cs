using System;
using System.Text;
using System.IO;

namespace SubtitleManager
{
  public class SrtSubtitleLine : ISubtitleLine
  {
    public TimeSpan Start { get; set; }
    public TimeSpan End { get; set; }
    public string Text { get; set; }
    public int LineNumber { get; set; }
    public SrtSubtitleLine()
    {

    }
    public SrtSubtitleLine(string subtitleText)
    {
      subtitleText = subtitleText.Trim();
      using (StringReader data = new StringReader(subtitleText))
      {
        LineNumber = int.Parse(data.ReadLine().Trim());

        string secondLine = data.ReadLine();
        Start = TimeSpan.ParseExact(secondLine.Substring(0, 12), @"hh\:mm\:ss\,fff", null);
        End = TimeSpan.ParseExact(secondLine.Substring(17, 12), @"hh\:mm\:ss\,fff", null);

        Text = data.ReadToEnd();
      }
    }
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(LineNumber.ToString());

      sb.Append(Start.ToString(@"hh\:mm\:ss\,fff"));
      sb.Append(" --> ");
      sb.Append(End.ToString(@"hh\:mm\:ss\,fff"));
      sb.AppendLine();

      sb.Append(Text);

      return sb.ToString();
    }
  }
}
