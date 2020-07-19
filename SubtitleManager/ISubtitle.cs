using System;
using System.Collections.Generic;

namespace SubtitleManager
{
  public interface ISubtitle
  {
    List<ISubtitleLine> Lines { get; set; }
  }
}
