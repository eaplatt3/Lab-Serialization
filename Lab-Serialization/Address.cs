using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab_Serialization
{
    [DataContract]
    class Address
    {
        string m_City;
        string m_State;

        public Address()
        {

        }

        [DataMember(Name = "city")]
        public string City
        {
            get
            {
                return m_City;
            }

            set
            {
                m_City = value;
            }
        }

        [DataMember(Name = "state")]
        public string State
        {
            get
            {
                return m_State;
            }

            set
            {
                m_State = value;
            }

        }
            public override string ToString()
        {
            return City + " " + State;
        }
    }
    
}
