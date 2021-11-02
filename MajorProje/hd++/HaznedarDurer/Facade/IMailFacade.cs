using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    [ServiceContract]
    public interface IMailFacade
    {
        [OperationContract]
        void SendMail(string body, string fullName, string title);
    }
}
