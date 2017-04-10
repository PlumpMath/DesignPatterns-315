using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class ChatRoom
    {
        private readonly IList<Participant> _participants =
           new List<Participant>();
        private Save save=new Save();

        public void SignOn(Participant participant)
        {
            _participants.Add(participant);
        }

        public void Send(string message, string from)
        {
            foreach (var participant in _participants)
            {
                participant.RecieveMessage(message, from);
            }
            save.OnDiskWrite(message, from);
        }
    }
}
