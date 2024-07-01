namespace ZooHomeWork;

public class Animals
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Sound { get; set; }
    public string Color { get; set; }
    public int getDosage()
    {
        return Age * 2;
    }
}