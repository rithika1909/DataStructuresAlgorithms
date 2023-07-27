using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class ReplaceString
    {
        public void StringReplace()
        {
            string line = "Hello <<name>>, We have your fullname as << full name >> in our system. your contact number is 91 - xxxxxxxxxx. Please,let us know in case of any clarification Thank you BridgeLabz 01 / 01 / 2016.";
            Console.WriteLine("Enter full name");
            string fullName=Console.ReadLine();
            line = line.Replace("<< full name >>", fullName);
            line = line.Replace("<<name>>", fullName);
            Console.WriteLine("Enter Phone Number");
            string number= Console.ReadLine();
            line = line.Replace("xxxxxxxxxx", number);
            Console.WriteLine("Final Result"+ line);
        }
    }
}
