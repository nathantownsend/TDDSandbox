using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TailSpinToys.UnitTesting
{

    [TestFixture]
    public class NUnitTests
    {

        [Test]
        public void SumOfTwoNumbers()
        {

            Assert.AreEqual(10, 5 + 5);

        }



        [Test]
        public void AreTheValuesTheSame()
        {

            Assert.AreSame(10, 5 + 6);

        }

    }

}