using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_CSV
{
    public class StyreModel
    {
        private string org;
        private string date;
        private string name;
        private string role;
        private string addr;
        private string postcode;
        private string city;
        private string birtDate;

        public string Org { get => org; set => org = value; }
        public string Date { get => date; set => date = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Postcode { get => postcode; set => postcode = value; }
        public string City { get => city; set => city = value; }
        public string BirtDate { get => birtDate; set => birtDate = value; }
    }
}
