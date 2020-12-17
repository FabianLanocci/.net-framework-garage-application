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
    public class XMLCashCount
    {
        private string RutaArchivo = @"C:\ArchivosXml\cashCounts.xml";

        public void GenerateXMLCashCounts(List<CashCount> cashCounts)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("CashCounts");

                foreach (CashCount cashCount in cashCounts)
                {
                    writer.WriteStartElement("CashCount");
                    writer.WriteElementString("Date", cashCount.Date.ToShortDateString());
                    writer.WriteStartElement("User");
                    writer.WriteElementString("UserName", cashCount.User.UserName);
                    writer.WriteElementString("Password", cashCount.User.Password);
                    writer.WriteElementString("LastAccess", cashCount.User.LastAcess.ToShortDateString());
                    writer.WriteElementString("Question", cashCount.User.Question);
                    writer.WriteElementString("Answer", cashCount.User.Answer);
                    writer.WriteEndElement();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<CashCount> GetCashCounts()
        {
            List <CashCount> cashCounts = new List<CashCount>();

            try
            {
                FileStream file = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
                XmlTextReader reader = new XmlTextReader(file);
                CashCount cashCount = null;
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch(reader.Name)
                        {
                            case "CashCounts":
                                {
                                    break;
                                }
                            case "CashCount":
                                {
                                    cashCount = new CashCount();
                                    break;
                                }
                            case "User":
                                {
                                    cashCount.User = new User();
                                    break;
                                }
                            case "Date":
                                {
                                    if(reader.Read())
                                        cashCount.Date = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "UserName":
                                {
                                    if(reader.Read())
                                        cashCount.User.UserName = reader.Value;
                                    break;
                                }
                            case "Password":
                                {
                                    if(reader.Read())
                                        cashCount.User.Password = reader.Value;
                                    break;
                                }
                            case "LastAccess":
                                {
                                    if(reader.Read())
                                        cashCount.User.LastAcess = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "Question":
                                {
                                    if (reader.Read())
                                        cashCount.User.Question = reader.Value;
                                    break;
                                }
                            case "Answer":
                                {
                                    if (reader.Read())
                                        cashCount.User.Answer = reader.Value;
                                    break;
                                }
                        }
                    }
                    else if (reader.Name == "CashCount")
                    {
                        cashCounts.Add(cashCount);
                        cashCount = null;
                    }
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cashCounts;
        }

        public bool ItsEmpty()
        {
            try
            {
                FileStream file = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
                if (file.Length == 0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
