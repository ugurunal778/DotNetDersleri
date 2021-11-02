using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralMediator
{
    //Concrete Colleague 1
    public class BasicUser : IUser
    {
        string name;
        IChatMediator chatMediator;

        public BasicUser(IChatMediator chatMediator, string name)
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
            Console.WriteLine("Kullanici Tipi: Basic -- " + name + "; Alinan Mesaj: " + message);
        }
    }
}
