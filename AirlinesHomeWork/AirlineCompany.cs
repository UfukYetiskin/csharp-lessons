namespace AirlineHomeWork;
public class Airline
{

    public string Name { get; set; }
    public string Country { get; set; }
    public string Callsign { get; set; }
    public string IATA { get; set; }
    public string ICAO { get; set; }
    public List<Plane> Plane { get; set; } = new List<Plane>();
    public string Status { get; set; }
    public string FlightID { get; set; }
    public string DepartureAirport { get; set; }
    public string ArrivalAirport { get; set; }
    public string DepartureTime { get; set; }
    public string ArrivalTime { get; set; }
    public List<Pilot> Pilot { get; set; } = new List<Pilot>();
    public string CoPilot { get; set; }
    public string AirportID { get; set; }
    public string AirportName { get; set; }




    public Airline() { }

    public Airline(string name, string country, string callsign, string iata, string icao)
    {
        Name = name;
        Country = country;
        Callsign = callsign;
        IATA = iata;
        ICAO = icao;
    }
}

public class Pilot
{
    public string PilotName { get; set; }
    public string PilotExperience { get; set; }
    public string PilotID { get; set; }
    public string PilotType { get; set; }
    public string PilotLicense { get; set; }
    public string PilotRating { get; set; }
    public string PilotPlane { get; set; }
    public string PilotPlaneType { get; set; }
    public string PilotPlaneID { get; set; }
    public string PilotPlaneStatus { get; set; }
    public string PilotPlaneLicense { get; set; }

    public Pilot() { }

    public Pilot(string pilotName, string pilotExperience, string pilotID, string pilotType, string pilotLicense, string pilotRating, string pilotPlane, string pilotPlaneType, string pilotPlaneID, string pilotPlaneStatus, string pilotPlaneLicense)
    {
        PilotName = pilotName;
        PilotExperience = pilotExperience;
        PilotID = pilotID;
        PilotType = pilotType;
        PilotLicense = pilotLicense;
        PilotRating = pilotRating;
        PilotPlane = pilotPlane;
        PilotPlaneType = pilotPlaneType;
        PilotPlaneID = pilotPlaneID;
        PilotPlaneStatus = pilotPlaneStatus;
        PilotPlaneLicense = pilotPlaneLicense;
    }
}

public class Plane
{
    public string PlaneID { get; set; }
    public string PlaneType { get; set; }
    public string PlaneStatus { get; set; }
    public string PlaneLicense { get; set; }
    public string PlanePilot { get; set; }
    public string PlaneCoPilot { get; set; }
    public string PlaneFlightID { get; set; }
    public string PlaneDepartureAirport { get; set; }
    public string PlaneArrivalAirport { get; set; }
    public string PlaneDepartureTime { get; set; }
    public string PlaneArrivalTime { get; set; }

    public Plane() { }

    public Plane(string planeID, string planeType, string planeStatus, string planeLicense, string planePilot, string planeCoPilot, string planeFlightID, string planeDepartureAirport, string planeArrivalAirport, string planeDepartureTime, string planeArrivalTime)
    {
        PlaneID = planeID;
        PlaneType = planeType;
        PlaneStatus = planeStatus;
        PlaneLicense = planeLicense;
        PlanePilot = planePilot;
        PlaneCoPilot = planeCoPilot;
        PlaneFlightID = planeFlightID;
        PlaneDepartureAirport = planeDepartureAirport;
        PlaneArrivalAirport = planeArrivalAirport;
        PlaneDepartureTime = planeDepartureTime;
        PlaneArrivalTime = planeArrivalTime;
    }
}