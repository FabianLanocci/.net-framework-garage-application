using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace TrabajoPracticoFinal
{
    public class XMLUsers
    {
        private string RutaArchivo = @"C:\ArchivosXml\users.xml";

        public void GenerateXMLUsers(List<User> users)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Users");

                foreach (User user in users)
                {

                    writer.WriteStartElement("User");
                    writer.WriteElementString("UserName", user.UserName);
                    writer.WriteElementString("Password", user.Password);
                    writer.WriteElementString("LastAccess", user.LastAcess.ToShortDateString());
                    writer.WriteElementString("Question", user.Question);
                    writer.WriteElementString("Answer", user.Answer);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
                if (!File.Exists(RutaArchivo))
                {
                    File.Create(RutaArchivo);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            try
            {
                FileStream file = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
                XmlTextReader reader = new XmlTextReader(file);
                User user = null;

                while(reader.Read())
                {
                    if(reader.IsStartElement())
                    {
                        switch(reader.Name)
                        {
                            case "Users":
                                {
                                    break;
                                }
                            case "User":
                                {
                                    user = new User();
                                    break;
                                }
                            case "UserName":
                                {
                                    if(reader.Read())
                                        user.UserName = reader.Value;
                                    break;
                                }
                            case "Password":
                                {
                                    if(reader.Read())
                                        user.Password = reader.Value;
                                    break;
                                }
                            case "LastAccess":
                                {
                                    if(reader.Read())
                                        user.LastAcess = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "Question":
                                {
                                    if (reader.Read())
                                    {
                                        user.Question = reader.Value;
                                    }
                                    break;
                                }
                            case "Answer":
                                {
                                    if (reader.Read())
                                    {
                                        user.Answer = reader.Value;
                                    }
                                    break;
                                }
                        }
                    }
                    else if(reader.Name == "User")
                    {
                        users.Add(user);
                        user = null;
                    }
                }
                reader.Close();
                file.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return users;
        }

        public bool ItsEmpty()
        {
            try
            {
                FileStream file = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);

                if(file.Length == 0 || !File.Exists(RutaArchivo))
                {
                    file.Close();
                    return true;
                }
                else
                {
                    file.Close();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
