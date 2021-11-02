namespace Repository
{
    public class BaseRepository
    {
        private MVCDataBaseEntities mvcFirstAppDbEntities;
        public MVCDataBaseEntities Model1
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
