public class Robot
{
    protected static int _nextOrderNumber = 1;
    
    private readonly int _orderNumber = _nextOrderNumber++;
    
    public Robot(int serialNumber, string name, string model)
    {
        _serialNumber = serialNumber;
        Name = name;
        Model = model;
    }

    /// <summary>
    /// Серийный номер
    /// </summary>
    public virtual int SerialNumber => _serialNumber;
    private readonly int _serialNumber;

    /// <summary>
    /// Имя
    /// </summary>
    public virtual string Name { get; }

    /// <summary>
    /// Модель
    /// </summary>
    public virtual string Model { get; }


    public override string ToString()
    {
        return $"({_orderNumber}) [{SerialNumber}] N:'{Name}' M: '{Model}'";
    }
}