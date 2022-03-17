using Jenkins_test;
using System;
using Xunit;

namespace TestProject
{
    public class TestController
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        //[Fact]
        //public void IsPrime_InputIs0_ReturnFalse()
        //{
        //    var primeService = new PrimeService();
        //    bool result = primeService.IsPrime(0);

        //    Assert.False(result, "0 should be prime");
        //}

        //[Fact]
        //public void IsPrime_InputIsMinus1_ReturnFalse()
        //{
        //    var primeService = new PrimeService();
        //    bool result = primeService.IsPrime(0);

        //    Assert.False(result, "-1 should be prime");
        //}

    }
}
