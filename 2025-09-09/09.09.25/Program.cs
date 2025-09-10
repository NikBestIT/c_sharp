var cook = new Robot(1050, "Tom", "Повар");

var spy = new RobotSpy(1000, "TomSpy", "Spy");

var counter = 1;
void PrintRobots(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{counter++}. {message}");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Модель повара: {cook}");
    Console.WriteLine($"Модель шпиона: {spy}");
    Console.WriteLine();
}

PrintRobots("Наши роботы");

// Маскируем шпиона под повара
spy.Mask(cook);

PrintRobots("Шпион замаскировался под повара");

spy.Unmask();

PrintRobots("Шпион размаскировался");

spy.Mask(cook);
spy.Unspy(ref cook);

PrintRobots("Убили повара и заменили его клоном");

spy.Unmask();

PrintRobots("Шпион размаскировался");

RobotSpy.SetNextOrderNumber(100);
var pochtalion = new Robot(100, "Fedya", "Pochtalion");

Console.WriteLine($"Почтальон: {pochtalion}");
