using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Lab_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Address add = new Address();

            String filename = "address.json";
            add.City = "Bronx";
            add.State = "New York";

            FileStream writer = new FileStream(filename, FileMode.Create, FileAccess.Write);

            DataContractJsonSerializer ser;
            ser = new DataContractJsonSerializer(typeof(Address));

            ser.WriteObject(writer, add);
            writer.Close();

            Address add2;
            String filename2 = "address.jason";

            FileStream reader = new FileStream(filename2, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(Address));

            add2 = (Address)inputSerializer.ReadObject(reader);
            reader.Close();
        }
    }
}
