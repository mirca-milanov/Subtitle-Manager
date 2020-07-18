using System;
using System.Collections.Generic;

namespace SubtitleManager
{
    public interface ISubtitle
    {
        List<ISubtitleBlock> Subtitles { get; set; }
    }
}
