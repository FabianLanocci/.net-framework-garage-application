using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace TrabajoPracticoFinal
{
    public class XMLMovements
    {
        private string RutaArchivo = @"C:\ArchivosXml\movements.xml";

        public void GenerateXMLMovements(List<Movement> movements)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Movements");

                foreach (Movement movement in movements)
                {
                    writer.WriteStartElement("Movement");
                    writer.WriteElementString("Concept", movement.Concept);
                    writer.WriteElementString("Amount", movement.Amount.ToString());
                    writer.WriteElementString("Date", movement.Date.ToShortDateString());
                    writer.WriteElementString("ItsIncome", movement.ItsIncome.ToString());
                    writer.WriteStartElement("User");
                    writer.WriteElementString("UserName", movement.User.UserName);
                    writer.WriteElementString("Password", movement.User.Password);
                    writer.WriteElementString("LastAccess", movement.User.LastAcess.ToShortDateString());
                    writer.WriteElementString("Question", movement.User.Question);
                    writer.WriteElementString("Answer", movement.User.Answer);
                    writer.WriteEndElement();
                    if(movement.CashCount != null)
                    {
                        writer.WriteStartElement("CashCount");
                        writer.WriteElementString("CashCountDate", movement.CashCount.Date.ToShortDateString());
                        writer.WriteStartElement("CashCountUser");
                        writer.WriteElementString("CashCountUserName", movement.CashCount.User.UserName);
                        writer.WriteElementString("CashCountPassword", movement.CashCount.User.Password);
                        writer.WriteElementString("CashCountLastAccess", movement.CashCount.User.LastAcess.ToShortDateString());
                        writer.WriteElementString("CashCountQuestion", movement.CashCount.User.Question);
                        writer.WriteElementString("CashCountAnswer", movement.CashCount.User.Answer);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
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

        public List<Movement> GetMovements()
        {
            List<Movement> movements = new List<Movement>();

            try
            {
                FileStream file = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
                XmlTextReader reader = new XmlTextReader(file);
                Movement movement = null;

                while(reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Movements":
                                {
                                    break;
                                }
                            case "Movement":
                                {
                                    movement = new Movement();
                                    break;
                                }
                            case "User":
                                {
                                    movement.User = new User();
                                    break;
                                }
                            case "CashCount":
                                {
                                    movement.CashCount = new CashCount();
                                    break;
                                }
                            case "CashCountUser":
                                {
                                    movement.CashCount.User = new User();
                                    break;
                                }
                            case "Concept":
                                {
                                    if(reader.Read())
                                        movement.Concept = reader.Value;
                                    break;
                                }
                            case "Amount":
                                {
                                    if(reader.Read())
                                        movement.Amount = Convert.ToDouble(reader.Value);
                                    break;
                                }
                            case "Date":
                                {
                                    if(reader.Read())
                                        movement.Date = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "ItsIncome":
                                {
                                    if(reader.Read())
                                        movement.ItsIncome = Convert.ToBoolean(reader.Value);
                                    break;
                                }
                            case "UserName":
                                {
                                    if(reader.Read())
                                        movement.User.UserName = reader.Value;
                                    break;
                                }
                            case "Password":
                                {
                                    if(reader.Read())
                                        movement.User.Password = reader.Value;
                                    break;
                                }
                            case "LastAccess":
                                {
                                    if(reader.Read())
                                        movement.User.LastAcess = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "Question":
                                {
                                    if (reader.Read())
                                        movement.User.Question = reader.Value;
                                    break;
                                }
                            case "Answer":
                                {
                                    if (reader.Read())
                                        movement.User.Answer = reader.Value;
                                    break;
                                }
                            case "CashCountDate":
                                {
                                    if(reader.Read())
                                        movement.CashCount.Date = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "CashCountUserName":
                                {
                                    if(reader.Read())
                                        movement.CashCount.User.UserName = reader.Value;
                                    break;
                                }
                            case "CashCountPassword":
                                {
                                    if(reader.Read())
                                        movement.CashCount.User.Password = reader.Value;
                                    break;
                                }
                            case "CashCountLastAccess":
                                {
                                    if(reader.Read())
                                        movement.CashCount.User.LastAcess = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "CashCountQuestion":
                                {
                                    if (reader.Read())
                                        movement.CashCount.User.Question = reader.Value;
                                    break;
                                }
                            case "CashCountAnswer":
                                {
                                    if (reader.Read())
                                        movement.CashCount.User.Answer = reader.Value;
                                    break;
                                }
                        }
                    }
                    else if (reader.Name == "Movement")
                    {
                        movements.Add(movement);
                        movement = null;
                    }
                }
                reader.Close();
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return movements;
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
