public class RobotSpy: Robot
{

    public static void SetNextOrderNumber(int nextOrderNumber)
    {
        _nextOrderNumber = nextOrderNumber ;
    }
    
    public RobotSpy(int serialNumber, string name, string model)
        : base(serialNumber, name, model)
    {
    }

    public override int SerialNumber => _serialNumber ?? base.SerialNumber;
    private int? _serialNumber;

    public override string Model => _model  ?? base.Model;
    private string? _model;
    
    public override string Name => _name  ?? base.Name;
    private string? _name;

    /// <summary>
    /// Маскируется под робота
    /// </summary>
    /// <param name="robot">Робот, под которого надо замаскироваться</param>
    public void Mask(Robot robot)
    {
        _serialNumber =  robot.SerialNumber;
        _model =  robot.Model;
        _name = robot.Name;
    }

    /// <summary>
    /// Размаскировывается
    /// </summary>
    public void Unmask()
    {
        _serialNumber = null;
        _model = null;
        _name = null;
    }

    /// <summary>
    /// Убивает робота, заменяя его клоном
    /// </summary>
    /// <param name="robot">Робот, которого убиваем и заменяем на клона</param>
    public void Unspy(ref Robot robot)
    {
        robot = new Robot(SerialNumber, Name, Model);
    }
}