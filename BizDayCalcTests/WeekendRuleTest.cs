using System;
using Xunit;
using BizDayCalc;


namespace BizDayCalcTests
{
    public class WeekendRuleTest
    {
        // Fact is a type of xUnit test.
        [Fact]
         public void TestCheckIsBusinessDay()
         {
            var rule = new WeekendRule();
            Assert.True(rule.CheckIsBusinessDay(new DateTime(2016, 6, 27)));
            Assert.False(rule.CheckIsBusinessDay(new DateTime(2016, 6, 26)));

         }
    }
}
