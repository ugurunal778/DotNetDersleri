using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralMediator
{
    //Concrete Colleague 2
    public class PremiumUser : IUser
    {
        string name;
        IChatMediator chatMediator;

        public PremiumUser(IChatMediator chatMediator, string name)
        {
            this.name = name;
            this.chatMediator = chatMediator;
        }

        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Kullanici tipi: Premium -- " + name + "; Alinan Mesaj: " + message);
        }
    }
}
