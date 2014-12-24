using DealerBLL.PublicInformation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerBLL.UnitTests
{
    [TestFixture]
    public class PublicInformationTests
    {
        IPublicInformationService _publicInformationService;

        [SetUp]
        public void Setup()
        {
            _publicInformationService = new PublicInformationService();
        }


        [Test]
        public void DealerHasName()
        {
            const string expected = "Dealer Name";
            var actual = _publicInformationService.GetDealerName();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DealerHasPhoneNumber()
        {
            const string expected = "(406) 461-9705";
            var actual = _publicInformationService.GetDealerPhoneNumber();
            Assert.AreEqual(expected, actual);
        }
    }
}
