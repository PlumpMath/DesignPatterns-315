using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
   public class Message
    {
        private readonly IList<Participant> _twoParticipants =
         new List<Participant>();


        public void SignOn(Participant participant)
        {
            _twoParticipants.Add(participant);
        }

        public void Send(string message, string from)
        {
            foreach (var participant in _twoParticipants)
            {
                participant.RecieveMessage(message, from);
            }
        }
    }
}
