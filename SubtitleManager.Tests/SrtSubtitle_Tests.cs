using Xunit;
using System;
using System.IO;

namespace SubtitleManager.Tests
{
    public class SrtSubtitleTests
    {
        public SrtSubtitle Subtitle { get; set; }
        public SrtSubtitleTests()
        {
            using StreamReader sr = new StreamReader(Path.Combine(Environment.CurrentDirectory, "sample-subtitle.srt"));
            string subtitleText = sr.ReadToEnd();
            Subtitle = new SrtSubtitle(subtitleText);
        }
        [Fact]
        public void SubtitleLengthEqualsTo10()
        {
            //Arrange
            int expected = 10;
            //Act
            int actual = Subtitle.Subtitles.Count;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LastSubtitleBlockTextValue()
        {
            //Arrange
            string expected = @"Took as much blood and spinal fluid";
            //Act
            string actual = Subtitle.Subtitles[9].Text;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}