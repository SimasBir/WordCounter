using FluentAssertions;
using WordCounter.Services;
using Xunit;

namespace WordCounterTests
{
    public class CalculationServiceTests
    {
        [Fact]
        public void CountWords_GivenSimpleString_CountWordsCorrectly()
        {
            var calculationService = new CalculationService();
            var testString = "two words";

            int result = calculationService.CountWords(testString);
            result.Should().Be(2);
        }

        [Fact]
        public void CountWords_GivenComplexString_CountWordsCorrectly()
        {
            var calculationService = new CalculationService();
            var testString = "Bulimulus is a genus of small to medium-sized tropical or sub-tropical, " +
                "air-breathing land snails, pulmonate gastropod mollusks in the subfamily Bulimulinae within" +
                " the family Bulimulidae." +
                "Bulimulus is the type genus of the subfamily Bulimulinae.[4] The shells are high and conical, " +
                "and are medium-sized, ranging from about 20 mm (0.8 inches) to about 50 mm (2 inches) long.";

            int result = calculationService.CountWords(testString);
            result.Should().Be(57); //seperated by "-" counts as two
        }

        [Fact]
        public void CountWords_GivenMathString_CountsNoWords()
        {
            var calculationService = new CalculationService();
            var testString = "100% - 1998.01.01-2007.10.12: 1967–68, 1968–69, 1970–71, " +
                "1971–72, 1972–73, 1974–75, 1975–76, 1976–77 ";

            int result = calculationService.CountWords(testString);
            result.Should().Be(0);
        }

        [Fact]
        public void CountChars_GivenShortString_CountsCorrectly()
        {
            var calculationService = new CalculationService();
            var testString = "two words";

            int result = calculationService.CountChars(testString);
            result.Should().Be(9);
        }
    }
}