using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProject
{
    class Print
    {
        private string CardID;

        public string Card()
        {
            return CardID;
        }
        public string Card(string cId)
        {
            CardID = cId;
            return "success";
        }
        public string Card(string cId, int exp)
        {
            CardID = cId+ exp;
            return "success";
        }


        public string Display(string name)
        {
            return name;
        }
        
        public string Display(string name, string surname)
        {
            return $"{name} {surname}";
        }
        public string Display(string name, string surname, int age)
        {
            return $"{name} {surname} yashiniz: {age}";
        }
        public string Display(string name, string surname, string middleName)
        {
            return $"{name} {surname} {middleName}";
        }

    }
}
