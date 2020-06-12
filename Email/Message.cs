using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Email
{
    public class Message
    {
        [XmlElement("Sender")]
        public string Sender { get; set; }
        [XmlAttribute]
        public string Recieve { get; set; }
        [XmlIgnore]
        public string Copy { get; set;}
        [XmlElement("Subject")]
        public string Subject { get; set; }
        [XmlElement("Body")]
        public string Body { get; set; }
        [XmlElement("date")]
        public string date { get; set; }

        public List<Attach> attachments { get; set; }
    }
}
