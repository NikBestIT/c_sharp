



Robot robotTom = new Robot("Tom", "Повар", 1050);


Console.WriteLine(robotTom.SerialNumber);

Console.WriteLine(robotTom.RobotName);

robotTom.SetName("Bob");

Console.WriteLine(robotTom.RobotName);


public class Robot

{
    //вариант 1
    private string _robotName;


    public string RobotName => _robotName;


    public void SetName(string name)


    {
        _robotName = name;
    }



    //вариант 2


    

    //вариант 3

    private string _model;

    public string Model 
    {
        get { return Model; }
        set
        {


            if (Model == "spy")
            {
                string[] models = { "1200", "1300", "1400" };

            }
            else
            {
                _model = value;
            }
        }

    }

    public Robot(string name, string model, int serialNumber)
    {
        _robotName = name;
        Model = model;
        SerialNumber = serialNumber;
    }


   
}


