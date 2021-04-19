using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class FizzBuzzWhizz
    {
        [Fact]
        public void Should_print_Fizz_when_number_is_3_time()
        {
            PrimeService primeService = new PrimeService(3);

            Assert.Equal("Fizz", primeService.getPrintWords());
        }

        [Fact]
        public void should_print_Buzz_when_number_is_5_time()
        {
            PrimeService primeService = new PrimeService(5);
            Assert.Equal("Buzz", primeService.getPrintWords());
        }

        [Fact]
        public void should_print_Whizz_when_number_is_7_time()
        {
            PrimeService primeService = new PrimeService(7);
            Assert.Equal("Whizz", primeService.getPrintWords());
        }

        [Fact]
        public void should_print_number_self_when_number_is_not_5_7_3_time()
        {
            PrimeService primeService = new PrimeService(1);
            Assert.Equal("1", primeService.getPrintWords());
        }

        [Fact]
        public void should_print_fizzBuzz_when_number_is_both_3_and_5_time()
        {
            PrimeService primeService = new PrimeService(15);
            Assert.Equal("FizzBuzz", primeService.getPrintWords());
        }

        [Fact]
        public void should_print_fizzWhizz_when_number_is_both_3_and_7_time()
        {
            PrimeService primeService = new PrimeService(42);
            Assert.Equal("FizzWhizz", primeService.getPrintWords());
        }

        [Fact]
        public void should_print_BuzzWhizz_when_number_is_both_5_and_7_time()
        {
            PrimeService primeService = new PrimeService(70);
            Assert.Equal("BuzzWhizz", primeService.getPrintWords());
        }
        [Fact]
        public void should_print_BuzzWhizz_when_number_is_both_3_and_5_and_7_time()
        {
            PrimeService primeService = new PrimeService(210);
            Assert.Equal("FizzBuzzWhizz", primeService.getPrintWords());
        }
        [Fact]
        public void should_print_fizz_when_number_contain_3()
        {
            PrimeService primeService = new PrimeService(13);
            Assert.Equal("Fizz", primeService.getPrintWords());
        }
    }
    
}