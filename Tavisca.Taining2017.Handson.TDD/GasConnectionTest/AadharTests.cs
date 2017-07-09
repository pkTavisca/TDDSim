using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GasConnection;

namespace GasConnectionTest
{
    [TestClass]
    public class AadharTests
    {
        [TestMethod]
        public void Validate_Aadhar_Character_Count()
        {
            InputClass inputClass = new InputClass();
            string aadharNo = inputClass.InputAadhar();
            Assert.IsNotNull(aadharNo);
            Assert.IsTrue(aadharNo.Length <= 12);
        }
    }
}
