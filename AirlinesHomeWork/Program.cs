// Hava yolu şirketleri uçuşları gerçekleştirir. Her hava yolunun bir kimliği vardır.
// Hava yolu şirketi, farklı tipteki uçaklara sahiptir.
// Uçaklar çalışır veya onarım durumunda olabilir.
// Her uçuşun benzersiz kimliği, kalkacağı ve ineceği havaalanı, kalkış ve iniş saatleri vardır.
// Her uçuşun bir pilotu ve yardımcı pilotu vardır ve uçağı kullanırlar.
// Havaalanlarının benzersiz kimlikleri ve isimleri vardır.
// Hava yolu şirketlerinin pilotları vardır ve her pilotun bir deneyim seviyesi mevcuttur.
// Bir uçak tipi, belirli sayıda pilota ihtiyaç duyabilir.

namespace AirlineHomeWork;

// AirlineCompany class
class Program
{
    static void Main(string[] args)
    {
        Airline turkish_airlines = new Airline();

        turkish_airlines.Name = "Turkish Airlines";
        turkish_airlines.Country = "Turkey";
        turkish_airlines.Callsign = "TURKISH";
        turkish_airlines.IATA = "TK";
        turkish_airlines.ICAO = "THY";
        turkish_airlines.Status = "Active";
        turkish_airlines.FlightID = "TK123";
        turkish_airlines.DepartureAirport = "IST";
        turkish_airlines.ArrivalAirport = "JFK";
        turkish_airlines.DepartureTime = "12:00";
        turkish_airlines.ArrivalTime = "18:00";
        turkish_airlines.AirportID = "IST";
        turkish_airlines.AirportName = "Istanbul Airport";
        turkish_airlines.Pilot.Add(new Pilot("John Doe", "10 years", "123", "Captain", "123", "5", "Boeing 737", "Passenger", "123", "Active", "123"));
        turkish_airlines.Pilot.Add(new Pilot("Sabuha Göçmesin", "5 years", "124", "Co-Pilot", "124", "4", "Boeing 737", "Passenger", "124", "Active", "124"));
        turkish_airlines.Plane.Add(new Plane("Boeing 737", "Passenger", "123", "Active", "123", "123", "123", "123", "123", "123", "123"));
        turkish_airlines.Plane.Add(new Plane("Boeing 737", "Passenger", "123", "Active", "123", "123", "123", "123", "123", "123", "123"));


        Airline pegasus_airlines = new Airline();
        pegasus_airlines.Name = "Pegasus Airlines";
        pegasus_airlines.Country = "Turkey";
        pegasus_airlines.Callsign = "PEGASUS";
        pegasus_airlines.IATA = "PC";
        pegasus_airlines.ICAO = "PGT";
        pegasus_airlines.Status = "Active";
        pegasus_airlines.FlightID = "PC123";
        pegasus_airlines.DepartureAirport = "SAW";
        pegasus_airlines.ArrivalAirport = "LTN";
        pegasus_airlines.DepartureTime = "12:00";
        pegasus_airlines.ArrivalTime = "18:00";
        pegasus_airlines.AirportID = "SAW";
        pegasus_airlines.AirportName = "Sabiha Gökçen Airport";
        pegasus_airlines.Pilot.Add(new Pilot("Jane Doe", "10 years", "123", "Captain", "123", "5", "Boeing 737", "Passenger", "123", "Active", "123"));
        pegasus_airlines.Pilot.Add(new Pilot("Sabuha Göçmesin", "5 years", "124", "Co-Pilot", "124", "4", "Boeing 737", "Passenger", "124", "Active", "124"));
        pegasus_airlines.Plane.Add(new Plane("Boeing 737", "Passenger", "123", "Active", "123", "123", "123", "123", "123", "123", "123"));
        pegasus_airlines.Plane.Add(new Plane("Boeing 737", "Passenger", "123", "Active", "123", "123", "123", "123", "123", "123", "123"));


        //Airline Listeleme
        List<Airline> airlines = new List<Airline>();
        airlines.Add(turkish_airlines);
        airlines.Add(pegasus_airlines);

        foreach (var airline in airlines)
        {
            //All Datas
            Console.WriteLine("Airline Name: " + airline.Name);
            Console.WriteLine("Airline Country: " + airline.Country);
            Console.WriteLine("Airline Callsign: " + airline.Callsign);
            Console.WriteLine("Airline IATA: " + airline.IATA);
            Console.WriteLine("Airline ICAO: " + airline.ICAO);
            Console.WriteLine("Airline Status: " + airline.Status);
            Console.WriteLine("Airline FlightID: " + airline.FlightID);
            Console.WriteLine("Airline DepartureAirport: " + airline.DepartureAirport);
            Console.WriteLine("Airline ArrivalAirport: " + airline.ArrivalAirport);
            Console.WriteLine("Airline DepartureTime: " + airline.DepartureTime);
            Console.WriteLine("Airline ArrivalTime: " + airline.ArrivalTime);
            Console.WriteLine("Airline AirportID: " + airline.AirportID);
            Console.WriteLine("Airline AirportName: " + airline.AirportName);

            //Pilot Listeleme
            foreach (var pilot in airline.Pilot)
            {
                Console.WriteLine("Pilot Name: " + pilot.PilotName);
                Console.WriteLine("Pilot Experience: " + pilot.PilotExperience);
                Console.WriteLine("Pilot ID: " + pilot.PilotID);
                Console.WriteLine("Pilot Type: " + pilot.PilotType);
                Console.WriteLine("Pilot License: " + pilot.PilotLicense);
                Console.WriteLine("Pilot Rating: " + pilot.PilotRating);
                Console.WriteLine("Pilot Plane: " + pilot.PilotPlane);
                Console.WriteLine("Pilot Plane Type: " + pilot.PilotPlaneType);
                Console.WriteLine("Pilot Plane ID: " + pilot.PilotPlaneID);
                Console.WriteLine("Pilot Plane Status: " + pilot.PilotPlaneStatus);
                Console.WriteLine("Pilot Plane License: " + pilot.PilotPlaneLicense);
            }

            //Plane Listeleme
            foreach (var plane in airline.Plane)
            {
                Console.WriteLine("Plane Name: " + plane.PlaneID);
                Console.WriteLine("Plane Type: " + plane.PlaneType);
                Console.WriteLine("Plane ID: " + plane.PlaneID);
                Console.WriteLine("Plane Status: " + plane.PlaneStatus);
                Console.WriteLine("Plane License: " + plane.PlaneLicense);
                Console.WriteLine("Plane Pilot: " + plane.PlanePilot);
                Console.WriteLine("Plane Pilot Type: " + plane.PlaneCoPilot);
                Console.WriteLine("Plane Pilot ID: " + plane.PlaneArrivalAirport);
                Console.WriteLine("Plane Pilot Status: " + plane.PlaneDepartureAirport);
                Console.WriteLine("Plane Pilot License: " + plane.PlaneDepartureTime);
                Console.WriteLine("Plane Pilot License: " + plane.PlaneArrivalTime);

            }
        }


    }
}



