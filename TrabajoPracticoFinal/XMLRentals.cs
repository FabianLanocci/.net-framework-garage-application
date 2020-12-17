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
    public class XMLRentals
    {
        private string RutaArchivo = @"C:\ArchivosXml\rentals.xml";

        public void GenerateXMLRentals(List<Rental> rentals)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(RutaArchivo, null);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Rentals");

                foreach (Rental rental in rentals)
                {
                    if (rental is RentalHour)
                    {
                        RentalHour rentalHour = rental as RentalHour;

                        writer.WriteStartElement("RentalHour");
                        writer.WriteElementString("Date", rentalHour.Date.ToLongDateString());
                        writer.WriteElementString("Since", rentalHour.Since.ToShortDateString());
                        writer.WriteElementString("Until", rentalHour.Until.ToShortDateString());
                        writer.WriteStartElement("Garage");
                        writer.WriteElementString("Number", rentalHour.Garage.Number.ToString());
                        writer.WriteElementString("Ubication", rentalHour.Garage.Ubication);
                        writer.WriteElementString("State", rentalHour.Garage.State.ToString());
                        writer.WriteStartElement("Vehicle");
                        writer.WriteElementString("Domain", rentalHour.Garage.Vehicle.Domain);
                        writer.WriteElementString("Brand", rentalHour.Garage.Vehicle.Brand);
                        writer.WriteElementString("Model", rentalHour.Garage.Vehicle.Model);
                        writer.WriteStartElement("TypeVehicle");
                        writer.WriteElementString("Code", rentalHour.Garage.Vehicle.TypeVehicle.Code);
                        writer.WriteElementString("Description", rentalHour.Garage.Vehicle.TypeVehicle.Description);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    else
                    {
                        RentalMonth rentalMonth = rental as RentalMonth;

                        writer.WriteStartElement("RentalMonth");
                        writer.WriteElementString("Date", rentalMonth.Date.ToShortDateString());
                        writer.WriteElementString("Holder", rentalMonth.Holder);
                        writer.WriteElementString("DueDate", rentalMonth.DueDate.ToShortDateString());
                        writer.WriteStartElement("Garage");
                        writer.WriteElementString("Number", rentalMonth.Garage.Number.ToString());
                        writer.WriteElementString("Ubication", rentalMonth.Garage.Ubication);
                        writer.WriteElementString("State", rentalMonth.Garage.State.ToString());
                        writer.WriteStartElement("Vehicle");
                        writer.WriteElementString("Domain", rentalMonth.Garage.Vehicle.Domain);
                        writer.WriteElementString("Brand", rentalMonth.Garage.Vehicle.Brand);
                        writer.WriteElementString("Model", rentalMonth.Garage.Vehicle.Model);
                        writer.WriteStartElement("TypeVehicle");
                        writer.WriteElementString("Code", rentalMonth.Garage.Vehicle.TypeVehicle.Code);
                        writer.WriteElementString("Description", rentalMonth.Garage.Vehicle.TypeVehicle.Description);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
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


        public List<Rental> GetRentals()
        {
            List<Rental> rentals = new List<Rental>();

            try
            {
                FileStream file = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
                XmlTextReader reader = new XmlTextReader(file);

                Rental rental = null;
                RentalHour rentalHour = null;
                RentalMonth rentalMonth = null;

                while(reader.Read())
                {
                    if(reader.IsStartElement())
                    {
                        switch(reader.Name)
                        {
                            case "Rentals":
                                {
                                    break;
                                }
                            case "RentalHour":
                                {
                                    rental = new RentalHour();
                                    break;
                                }
                            case "RentalMonth":
                                {
                                    rental = new RentalMonth();
                                    break;
                                }
                            case "Date":
                                {
                                    if(reader.Read())
                                        rental.Date = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "Since":
                                {
                                    if(reader.Read())
                                        rentalHour = rental as RentalHour;
                                        rentalHour.Since = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "Until":
                                {
                                    if(reader.Read())
                                        rentalHour = rental as RentalHour;
                                        rentalHour.Until = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "Holder":
                                {
                                    if(reader.Read())
                                        rentalMonth = rental as RentalMonth;
                                        rentalMonth.Holder = reader.Value;
                                    break;
                                }
                            case "DueDate":
                                {
                                    if(reader.Read())
                                        rentalMonth = rental as RentalMonth;
                                        rentalMonth.DueDate = Convert.ToDateTime(reader.Value);
                                    break;
                                }
                            case "Garage":
                                {
                                    if(reader.Read())
                                        rental.Garage = new Garage();
                                    break;
                                }
                            case "Vehicle":
                                {
                                    if (reader.Read())
                                        rental.Garage.Vehicle = new Vehicle();
                                    break;
                                }
                            case "TypeVehicle":
                                {
                                    if (reader.Read())
                                        rental.Garage.Vehicle.TypeVehicle = new TypeVehicle();
                                    break;
                                }
                            case "Number":
                                {
                                    if(reader.Read())
                                        rental.Garage.Number = Convert.ToInt16(reader.Value);
                                    break;
                                }
                            case "Ubication":
                                {
                                    if(reader.Read())
                                        rental.Garage.Ubication = reader.Value;
                                    break;
                                }
                            case "State":
                                {
                                    if(reader.Read())
                                        rental.Garage.State = Convert.ToBoolean(reader.Value);
                                    break;
                                }
                            case "Domain":
                                {
                                    if(reader.Read())
                                        rental.Garage.Vehicle.Domain = reader.Value;
                                    break;
                                }
                            case "Brand":
                                {
                                    if(reader.Read())
                                        rental.Garage.Vehicle.Brand = reader.Value;
                                    break;
                                }
                            case "Model":
                                {
                                    if(reader.Read())
                                        rental.Garage.Vehicle.Model = reader.Value;
                                    break;
                                }
                            case "Code":
                                {
                                    if(reader.Read())
                                        rental.Garage.Vehicle.TypeVehicle.Code = reader.Value;
                                    break;
                                }
                            case "Description":
                                {
                                    if(reader.Read())
                                        rental.Garage.Vehicle.TypeVehicle.Description = reader.Value;
                                    break;
                                }

                        }
                    }
                    else if(reader.Name == "RentalHour" || reader.Name == "RentalMonth")
                    {
                        rentals.Add(rental);
                        rental = null;
                    }
                }
                reader.Close();
                file.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rentals;
        }

        public bool ItsEmpty()
        {
            try
            {
                FileStream file = new FileStream(RutaArchivo, FileMode.Open, FileAccess.Read);
                if(file.Length ==0)
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
