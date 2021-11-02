using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralMediator
{
    //Concrete Mediator
    public class ChatMediator : IChatMediator
    {
        List<IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (IUser user in users)
            {
                // gonderici mesaji alamasin !
                if (user != sender)
                    user.ReceiveMessage(message);
            }
        }
    }
}
