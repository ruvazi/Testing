using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondUnitTestHandin;

namespace UnitSecondHandin
{
    [TestClass]
    public class Reimbursements
    {
        Reimbursement re;
        [TestInitialize]
        public void beforeTest()
        {
            re = new Reimbursement();
        }

        // Reimbursement tests

        [TestMethod()]
        public void DeductableMetDoctorsVisit()
        {
            Assert.AreEqual(re.reimbursementPercentage(true, "d"), 50);
        }

        [TestMethod()]
        public void DeductableNotMetDoctorsVisit()
        {
            Assert.AreEqual(re.reimbursementPercentage(false, "d"), 0);
        }

        [TestMethod()]
        public void DeductableMetHospitalVisit()
        {
            Assert.AreEqual(re.reimbursementPercentage(true, "h"), 80);
        }

        [TestMethod()]
        public void DeductableNotMetHospitalVisit()
        {
            Assert.AreEqual(re.reimbursementPercentage(false, "h"), 0);
        }

    }
}
