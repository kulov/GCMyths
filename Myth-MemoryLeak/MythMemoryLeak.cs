using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace GCMyths
{
    static class MythMemoryLeak
    {
        private static EventProvider g_eventProvider = new EventProvider();

        static void Main(string[] args)
        {
//            CallXmlSerializerLeak();

            CallEventSubscriberLeak();
        }

        #region EventSerializerLeak

        private static void CallEventSubscriberLeak()
        {
            var es = new EventSubscriber(g_eventProvider);
            es = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        #endregion EventSerializerLeak

        #region XmlSerializerLeak

        private static void CallXmlSerializerLeak()
        {
            while (true)
            {
                var s = new XmlSerializer(typeof(XmlSerializerLeak), new Type[] { });
                s.Serialize(Stream.Null, new XmlSerializerLeak { });
            }
        }

        #endregion XmlSerializerLeak
    }
}
