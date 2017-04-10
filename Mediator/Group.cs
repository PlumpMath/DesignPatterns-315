using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
   public class Group
    {
        private readonly IList<Participant> _groupParticipants =
          new List<Participant>();


        public void SignOn(Participant participant)
        {
            _groupParticipants.Add(participant);
        }

        public void Send(string message, string from)
        {
            foreach (var participant in _groupParticipants)
            {
                participant.RecieveMessage(message, from);
            }
        }
    }
}
