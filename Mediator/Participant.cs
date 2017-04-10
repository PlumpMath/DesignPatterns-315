using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
   public class Participant
    {
        private readonly ChatRoom _chatRoom;
        private readonly Message _msg;
        private readonly Group _group;
        private readonly string _name;

        public Participant(ChatRoom chatRoom, string name)
        {
            _chatRoom = chatRoom;
            _name = name;
            _chatRoom.SignOn(this);
        }
        public Participant(Group group, string name)
        {
            _group = group;
            _name = name;
            _group.SignOn(this);
        }

        public Participant(Message msg, string name)
        {
            _msg = msg;
            _name = name;
            _msg.SignOn(this);
        }
        public void RecieveMessage(string message, string from)
        {
            if (_name != from)
            {
                Console.WriteLine("{0} recieved a message from {1}: {2}",
                    _name, from, message);
            }
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Sent from {0}: {1}", _name, message);
            _chatRoom.Send(message, _name);
        }
        public void SendMessageGroup(string message)
        {
            Console.WriteLine("Sent from {0}: {1}", _name, message);
            _group.Send(message, _name);
        }

        public void Send(string message)
        {
            Console.WriteLine("Sent from {0}: {1}", _name, message);
            _msg.Send(message, _name);
        }
    }
}
