namespace DataLayer
{
    public class BaseRepository
    {
        private xfvkxruc_phonebookEntities _tranferMarketModel;
        public xfvkxruc_phonebookEntities TransferMarketModel
        {
            get
            {
                if (_tranferMarketModel is null)
                    _tranferMarketModel = new xfvkxruc_phonebookEntities();
                return _tranferMarketModel;
            }
        }
    }
}
