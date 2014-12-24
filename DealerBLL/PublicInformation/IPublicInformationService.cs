using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerBLL.PublicInformation
{
    public interface IPublicInformationService
    {
        string GetDealerName();

        string GetDealerPhoneNumber();
    }
}
