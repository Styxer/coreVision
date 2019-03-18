using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using coreVision.Models;

namespace coreVision.DAL
{
    public class LandingPageRepositroy :ILandingPageRepositiry, IDisposable
    {
        private dbModels context;

        public LandingPageRepositroy(dbModels context)
        {
            this.context = context;
        }

        public void InsertData(landingPage landingPage)
        {
            context.landingPages.Add(landingPage);
        }

        public IEnumerable<landingPage> getData()
        {
            return context.landingPages.ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

       protected virtual void Dispose(bool  disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

       public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        
    }
}