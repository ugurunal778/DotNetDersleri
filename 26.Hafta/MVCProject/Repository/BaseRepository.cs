using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BaseRepository
    {
        private MvcFirstAppDbEntities mvcFirstAppDbEntities;
        public MvcFirstAppDbEntities Model
        {
            get
            {
                if (mvcFirstAppDbEntities is null)
                    mvcFirstAppDbEntities = new MvcFirstAppDbEntities();
                return mvcFirstAppDbEntities;
            }
        }
    }
}
