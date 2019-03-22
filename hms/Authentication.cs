using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace hms
{
    class Authentication
    {
        private String username;
        private String password;
        private String result;
        private XmlDocument userDoc;
        private XmlNodeList nodeList;
        public Authentication(String user,String pass)
        {
            this.username = user;
            this.password = pass;
        }
        public String checkPass
        {
            get
            {
                userDoc = new XmlDocument();
                userDoc.Load("database/user.xml");
                nodeList = userDoc.SelectNodes("userLogin/user");
                foreach (XmlNode node in nodeList)
                {
                    if (node["userType"].InnerText == "Admin")
                    {
                        if (node["userName"].InnerText == username && node["userPassword"].InnerText == password)
                        {
                            result = "Admin";
                        }


                    }
                    else if (node["userType"].InnerText == "User")
                    {
                        if (node["userName"].InnerText == username && node["userPassword"].InnerText == password)
                        {
                            result = "User";
                        }


                    }
                }
                return result;
            }
            set
            {
                username = value;
                password = value;
                   
                

            }

        }
    }
}
