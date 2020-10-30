using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGraph2.Models
{
    public class DataAccesEmploye
    {
        public static List<EmployeModel> getEmployeList()
        {
            var list = new List<EmployeModel>();
            list.Add(new EmployeModel { name = "Pierre lang", manager = "", toolTip = "Board of Directors", workPosition = "Board of Directors" });
            list.Add(new EmployeModel { name = "Mary Jackson", manager = "Pierre lang", toolTip = "Excecutive Director", workPosition = "Excecutive Director" });
            list.Add(new EmployeModel { name = "Robert Thompson", manager = "Mary Jackson", toolTip = "Volunters", workPosition = "Volunters" });
            list.Add(new EmployeModel { name = "David Ellison", manager = "Mary Jackson", toolTip = "Excecutive Staff Manager", workPosition = "Excecutive Staff Manager" });
            list.Add(new EmployeModel { name = "Carl Stevens", manager = "Robert Thompson", toolTip = "Finance Director", workPosition = "Finance Director" });
            list.Add(new EmployeModel { name = "Nancy Sakamoto", manager = "Robert Thompson", toolTip = "Fundraising Director", workPosition = "Fundraising Director" });
            list.Add(new EmployeModel { name = "Tiffin Kiling", manager = "Robert Thompson", toolTip = "Fundraising Director", workPosition = "Operations Director" });
            list.Add(new EmployeModel { name = "Francis Whitacre", manager = "Robert Thompson", toolTip = "Program Director", workPosition = "Program Director" });
            list.Add(new EmployeModel { name = "Bety Carison", manager = "Robert Thompson", toolTip = "Communications Director", workPosition = "Communications Director" });

            return list;

        }

    }
}
