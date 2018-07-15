using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassLibrary1
{
    public class Organization
    {
        public string orgType { get; set; }
        public string orgName { get; set; }
        public string orgAddress1 { get; set; }
        public string orgAddress2 { get; set; }
        public string orgCity { get; set; }
        public string orgState { get; set; }
        public string orgZipCode { get; set; }
        public string orgPhone { get; set; }
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
        public Organization()
        {
            orgName = "Avila Consulting";
            orgTwitter = "@therealjvasquez";
        }

        public Organization(string name, string Twitter)
        {
            orgName = name;
            orgTwitter = Twitter;


        }

        public static float maxPrice (float priceOne, float priceTwo, float priceThree)
        {
            var result = (priceOne + priceTwo + priceThree) / 3;
            return result;
        }

        public static float maxPrice(int priceOne, int priceTwo, int priceThree)
        {
            var result = (priceOne + priceTwo + priceThree) / 3;
            return result;
        }

    }


}
