using cs12_paskaita_XUnit;
using System;
using System.Collections.Generic;
using Xunit;

namespace xUnit_Problem1
{
    public class UnitTest1
    {
        [Fact]
        public void Is_Calculations_Correct()
        {
            // Arange
            var Trimester1 = new List<int> { 10, 10, 10 };
            var Trimester2 = new List<int> { 9, 9, 9 };
            var Trimester3 = new List<int> { 8, 8, 8 };

            var allGrades = new Problem1Struct(Trimester1, Trimester2, Trimester3);
            allGrades.PrintValues();

            // Act
            int test1result = allGrades.TrimAvg(Trimester1);
            int test2result = allGrades.TrimAvg(Trimester2);
            int test3result = allGrades.TrimAvg(Trimester3);

            int test4result =allGrades.YearAvg(Trimester1, Trimester2, Trimester3);

            // Asert
            Assert.Equal(10, test1result);
            Assert.Equal(9, test2result);
            Assert.Equal(8, test3result);
            Assert.Equal(9, test4result);
        }
    }
}
