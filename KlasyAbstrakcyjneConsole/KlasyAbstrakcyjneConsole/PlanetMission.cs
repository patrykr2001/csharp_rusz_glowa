namespace KlasyAbstrakcyjneConsole;

public abstract class PlanetMission
{
    protected float fuelPerKm;
    protected long kmPerHour;
    protected long kmToPlanet;

    public string MissionInfo()
    {
        long fuel = (long)(kmToPlanet * fuelPerKm);
        long time = kmToPlanet / kmPerHour;
        return $"Spalimy {fuel} jednostek paliwa w czasie {time}";
    }
}

public class Mars : PlanetMission
{
    public Mars()
    {
        kmToPlanet = 920000000;
        fuelPerKm = 1.73f;
        kmPerHour = 37000;
    }
}

public class Venus : PlanetMission
{
    public Venus()
    {
        kmToPlanet = 41000000;
        fuelPerKm = 2.11f;
        kmPerHour = 29500;
    }
}