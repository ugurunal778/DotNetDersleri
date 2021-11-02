namespace DataLayer
{
    public class BaseRepository
    {
        private xfvkxruc_phonebookEntities _transferMarketModel;
        public xfvkxruc_phonebookEntities TransferMarketModel
        {
            get
            {
                if (_transferMarketModel is null)
                    _transferMarketModel = new xfvkxruc_phonebookEntities();
                return _transferMarketModel;
            }
        }
    }
}
