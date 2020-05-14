using System;
using System.Threading;

namespace GCMyths
{
    public class EventSubscriber
    {
        private EventProvider _ep;

        public EventSubscriber(EventProvider ep)
        {
            this._ep = ep;
//            this._ep.EventReceived += Ep_EventReceived;
        }

        private void Ep_EventReceived(object sender, EventArgs e)
        {
            // process events
        }
    }
}
