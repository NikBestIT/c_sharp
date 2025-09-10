// See https://aka.ms/new-console-template for more information
Robot robotAllan = new Robot("Аллан", "модель 550", 123456789, "Строительный");

System.Console.WriteLine(robotAllan.Name);

robotAllan.Model = "модель 111";
System.Console.WriteLine(robotAllan.Model);

robotAllan.ShowInfo();

Robot robotArnold = new Robot("Арнольд", "T-800", 101, "Инфильтратор");

public class Robot
{
    public string Name;
    public string Model;
    public int SerialNumber;
    public string Type;

    public Robot(string name, string model, int serialNumber, string type)
    {
        this.Name = name;
        this.Model = model;
        this.SerialNumber = serialNumber;
        this.Type = type;
    }


    public void ShowInfo()
    {
        System.Console.WriteLine($"Я робот\n" +
        $"\t Моё имя {this.Name}\n" +
        $"\t Моя модель {this.Model}\n" +
        $"\t Мой серийный номер {this.SerialNumber}\n" +
        $"\t Моё назначение {this.Type}\n");
    }
}
