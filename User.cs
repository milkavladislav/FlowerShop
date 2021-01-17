using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    public class User
    {
        public string Name { get; set; }
        private string password;
        public string AccessType { get; private set; }

        public bool IsPasswordCorrect(string nickname, string pw)
        {
            string path = @"..\..\UserPassword.txt";
            StreamReader passwordFile = new StreamReader(path);

            Dictionary<string, string> usersDictionary = new Dictionary<string, string>();

            string line;
            while ((line = passwordFile.ReadLine()) != null)
            {
                if(line != "Customer:" && line != "Manager:")
                {
                    string user = nickname + ": " + pw;
                    if(line == user)
                    {
                        Name = nickname;
                        password = pw;
                        return true;
                    }
                }
                else
                {
                    SetAccess(line);
                }
            }
            return false;
        }

        private void SetAccess(string line)
        {
            if(line == "Customer:")
            {
                AccessType = "Customer";
            }
            else
            {
                AccessType = "Manager";
            }
        }

        public override string ToString()
        {
            return "Customer: " + Name + "; Access type: " + AccessType;
        }
    }
}
