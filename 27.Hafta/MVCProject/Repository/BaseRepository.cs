using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BaseRepository
    {
        private MVCDataBaseEntities mvcFirstAppDbEntities;
        public MVCDataBaseEntities Model
        {
            get
            {
                if (mvcFirstAppDbEntities is null)
                    mvcFirstAppDbEntities = new MVCDataBaseEntities();
                return mvcFirstAppDbEntities;
            }
        }


    }
}
