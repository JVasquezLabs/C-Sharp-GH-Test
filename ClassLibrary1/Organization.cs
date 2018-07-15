using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassLibrary1
{
    public class Organization
    {
        string orgType { get; set; }
        string orgName{ get; set; }
        string orgAddress1 { get; set; }
        string orgAddress2 { get; set; }
        string orgCity { get; set; }
        string orgState { get; set; }
        string orgZipCode { get; set; }
        string orgPhone { get; set; }
        private string _orgTwitter;
        public string orgTwitter
        {
            //Ensure Twitter address starts with @
            get
            {
                return _orgTwitter;
            }

            set
            {
                if (value.StartsWith("@"))
                {
                    _orgTwitter = value;
                }
                else
                {
                    throw new Exception("The Twitter address ust beging with @");
                }
            }


        }
    }
}
