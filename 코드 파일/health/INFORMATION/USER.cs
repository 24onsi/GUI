using System;
using System.Collections;

namespace LMS3_GUIproject.INFORMATION
{
    class User
    {
        public static string[] infolist = new string[9];

        private string pakage;
        public string Pakage
        {
            get { return pakage; }
            set { pakage = value; }
        }

        private string money;
        public string Money
        {
            get { return money; }
            set { money = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int identity_num1;
        public int Identity_Num1
        {
            get { return identity_num1; }
            set { identity_num1 = value; }
        }

        private int identity_num2;
        public int Identity_Num2
        {
            get { return identity_num2; }
            set { identity_num2 = value; }
        }

        private string phnum;
        public string PhNum
        {
            get { return phnum; }
            set { phnum = value; }
        }

        private string addr1;
        public string Addr1
        {
            get { return addr1; }
            set { addr1 = value; }
        }

        private string addr2;
        public string Addr2
        {
            get { return addr2; }
            set { addr2 = value; }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
