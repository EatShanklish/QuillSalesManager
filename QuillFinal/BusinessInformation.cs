using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuillFinal
{
    class BusinessInformation
    {
        public string bName;
        public string Baddress;
        public int AccNum;

        public BusinessInformation() // default constructor
        {
            bName = "uNKnown";
            Baddress = "3712 Pinehurst Street - Suite #130";
            AccNum = 234182;
        }

        public BusinessInformation(string _name, string _address) // constructor with two parameters
        {
            _name = bName;
            _address = Baddress;
            AccNum = 982712;
        }

        public BusinessInformation(string _name) // constructor with one.
        {
            _name = bName;
           
            AccNum = 982712;
        }

        public string NAME
        {
            get { return bName; }
            set { bName = value; }
        }
         
        public string ADDRESS
        {
            get { return Baddress; }
            set { Baddress = value; }
        }

        //Generates random business name
        public static string BussinessName()
        {
            Random rand = new Random();
            int x = rand.Next(5);
            string busname = "";


            switch (x)
            {
                case 0:
                    busname = "Jay's Food Shoppe";
                    break;

                case 1:
                    busname = "Motel 6";
                    break;

                case 2:
                    busname = "Falcon Inn";
                    break;

                case 3:
                    busname = "Hyde Family Dental";
                    break;

                case 4:
                    busname = "ETech Solutions";
                    break;

                case 5:
                    busname = "Advanced Eye Solutions";
                    break;
            }

            return busname;

        }

    }
}
