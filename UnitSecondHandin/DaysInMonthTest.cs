using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondUnitTestHandin;

namespace UnitSecondHandin
{
    [TestClass]
    public class DaysInMonthTest
    {
        [TestClass()]
        public class DaysInMonthTests
        {
            DaysInMonth dim;
            [TestInitialize]
            public void beforeTest()
            {
                dim = new DaysInMonth();
            }

            // four test one for Month one for year, one for both combined and lastly and boundary test for month.

            // Equivalences tests Month
            [TestMethod()]
            public void month1()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(1, 2017), 31);
            }

            [TestMethod()]
            public void month11()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(11, 2017), 30);
            }

            [TestMethod()]
            public void monthFebruaryAndNotLeapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 2017), 28);
            }

            [TestMethod()]
            public void monthFebruaryAndLeapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 2016), 29);
            }

            [TestMethod()]
            public void monthLessThan1()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(-3, 2017), 0);
            }

            [TestMethod()]
            public void monthMoreThan12()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(16, 2017), 0);
            }

            // Equivalences tests Year
            [TestMethod()]
            public void leapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 4), 29);
            }

            [TestMethod()]
            public void leapYear400()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 400), 29);
            }

            [TestMethod()]
            public void nonLeapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 1), 28);
            }

            [TestMethod()]
            public void nonLeapYear100()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 100), 28);
            }

            [TestMethod()]
            public void yearLessThan0()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, -50), 0);
            }

            [TestMethod()]
            public void yearGreaterThanMaxInt()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, int.MaxValue), 0);
            }

            // Equivalences tests Month + Year
            [TestMethod()]
            public void month1LeapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(1, 4), 31);
            }

            [TestMethod()]
            public void month1NonLeapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(1, 1), 31);
            }

            [TestMethod()]
            public void month9LeapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(9, 4), 30);
            }

            [TestMethod()]
            public void month9NonLeapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(9, 1), 30);
            }

            [TestMethod()]
            public void month2AndLeapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 2016), 29);
            }

            [TestMethod()]
            public void month2AndNotLeapYear()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 2017), 28);
            }

            // Boundary test month
            [TestMethod()]
            public void boundaryLeapYear400()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 398), 28);
                Assert.AreEqual(dim.getNumDaysinMonth(2, 399), 28);
                Assert.AreEqual(dim.getNumDaysinMonth(2, 400), 29);
                Assert.AreEqual(dim.getNumDaysinMonth(2, 401), 28);
                Assert.AreEqual(dim.getNumDaysinMonth(2, 402), 28);
            }

            [TestMethod()]
            public void boundaryNonLeapYear100()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(2, 98), 28);
                Assert.AreEqual(dim.getNumDaysinMonth(2, 99), 28);
                Assert.AreEqual(dim.getNumDaysinMonth(2, 100), 28);
                Assert.AreEqual(dim.getNumDaysinMonth(2, 101), 28);
                Assert.AreEqual(dim.getNumDaysinMonth(2, 102), 28);
            }

            [TestMethod()]
            public void boundaryNonPositiveMonth()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(-1, 10), 0);
                Assert.AreEqual(dim.getNumDaysinMonth(0, 10), 0);
                Assert.AreEqual(dim.getNumDaysinMonth(1, 10), 31);
                Assert.AreEqual(dim.getNumDaysinMonth(2, 10), 28);
            }

            [TestMethod()]
            public void boundaryPositiveMonth()
            {
                Assert.AreEqual(dim.getNumDaysinMonth(11, 10), 30);
                Assert.AreEqual(dim.getNumDaysinMonth(12, 10), 31);
                Assert.AreEqual(dim.getNumDaysinMonth(13, 10), 0);
                Assert.AreEqual(dim.getNumDaysinMonth(14, 10), 0);
            }
        }
    }
}
