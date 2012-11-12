using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class Category
    {
        [DataMember(Name="id")]
        public int ID { get; set; }
        [DataMember(Name="title")]
        public string Title { get; set; }
    }
}
