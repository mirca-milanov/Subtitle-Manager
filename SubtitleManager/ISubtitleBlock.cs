using System;

namespace SubtitleManager
{
    public interface ISubtitleBlock
    {
        TimeSpan Start { get; set; }
        TimeSpan End { get; set; }
        string Text { get; set; }
    }
}
