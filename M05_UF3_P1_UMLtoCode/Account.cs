using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P1_UMLtoCode
{
    public class Account
    {
        public string IBAN;
        protected float Amount;

        public bool Transaction(string path)
        {
            return true;
        }
        public Transaction trans;
    }

    public class Investing : Account
    {
        public float Interest;
        public string ApplyInterest()
        {
            return "";
        }
    }

    public class Savings : Account
    {
        private float ProtectedAmount;

        public string LiberateSavings()
        {
            return "";
        }
    }
}
