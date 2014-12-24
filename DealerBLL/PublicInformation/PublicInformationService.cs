using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealerDAL.Service;

namespace DealerBLL.PublicInformation
{
    public class PublicInformationService: IPublicInformationService
    {
        private ICompanyService _companyService;

        public string GetDealerName()
        {
            return "Dealer Name";
        }


        public string GetDealerPhoneNumber()
        {
            return "(406) 461-9705";
        }
    }
}
