using coreVision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreVision.DAL
{
    public interface ILandingPageRepositiry : IDisposable
    {
        //landingPage getDataByX(int x);
       // void DeleteData(landingPage landingPage);
       // void UpdateData(landingPage landingPage);

        IEnumerable<landingPage> getData();
        void InsertData(landingPage landingPage);
        void Save();
    }
}
