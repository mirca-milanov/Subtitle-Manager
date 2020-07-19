using System;

namespace SubtitleManager
{
  public interface ISubtitleLine
  {
    TimeSpan Start { get; set; }
    TimeSpan End { get; set; }
    string Text { get; set; }
  }
}
