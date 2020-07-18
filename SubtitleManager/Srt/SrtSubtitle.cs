using System;
using System.Collections.Generic;

namespace SubtitleManager
{
    public class SrtSubtitle : ISubtitle
    {
        public List<ISubtitleBlock> Subtitles { get; set; }
    }
}
