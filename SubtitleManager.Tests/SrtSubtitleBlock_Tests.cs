using Xunit;
using System;

namespace SubtitleManager.Tests
{
    public class SrtSubtitleBlockTests
    {
        private static string subtitleText = @"157
00:02:17,440 --> 00:02:20,375
Senator, we're making
our final approach into Coruscant.";
        private SrtSubtitleBlock subtitleBlock = new SrtSubtitleBlock(subtitleText);

        [Fact]
        public void ShouldParseLineNumber()
        {
            int lineNumber = subtitleBlock.LineNumber;
            //Then -- Assert
            Assert.Equal(157, lineNumber);
        }
        [Fact]
        public void ShouldParseStartTime()
        {
            //Given -- Arrange
            TimeSpan expectedTime = new TimeSpan(0, 0, 2, 17, 440);
            //When -- Act
            TimeSpan startTime = subtitleBlock.Start;
            //Then -- Assert
            Assert.Equal(expectedTime, startTime);
        }
        [Fact]
        public void ShouldParseEndTime()
        {
            //Given -- Arrange
            TimeSpan expectedTime = new TimeSpan(0, 0, 2, 20, 375);
            //When -- Act
            TimeSpan startTime = subtitleBlock.End;
            //Then -- Assert
            Assert.Equal(expectedTime, startTime);
        }
        [Fact]
        public void ShouldParseText()
        {
            //Arrange
            string expectedText = @"Senator, we're making
our final approach into Coruscant.";
            //Act
            string actualText = subtitleBlock.Text;
            //Assert
            Assert.Equal(actualText, expectedText);
        }
        [Fact]
        public void ShouldSerializeBlock()
        {
            //Arrange
            string expected = @"157
00:02:17,440 --> 00:02:20,375
Senator, we're making
our final approach into Coruscant.";
            //Act
            string actual = subtitleBlock.ToString();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}