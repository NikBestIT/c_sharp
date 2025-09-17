using KT1.Entities;

var library = new Library(
    "СПб, КОндратьевский пр., д.71",
    [
        "Щелкунчик",
        "Война и Мир",
        "Преступление и наказание"
    ]);

var nikita = new Reader("Никита", "Бестфатор", 18);
Console.WriteLine(nikita);

var vadim = new Reader("Вадим", "Бестфатор", 13);
var ilya = new Reader("Илья", "Бестфатор", 10);

nikita.ReadBook(library, "Война и Мир");
vadim.ReadBook(library, "Незнайка на луне");
ilya.ReadBook(library, "Щелкунчик");


void CatchError(string theory, Action action)
{
    try
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine();
        Console.WriteLine($"{theory}:");

        action();
    }
    catch (Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"  {e.Message}");
    }

    Console.ForegroundColor = ConsoleColor.White;
}

CatchError(
    "Проверяем создание библиотеки с пустым адресом",
    () => new Library("", ["Щелкунчик"])
);

CatchError(
    "Проверяем на пустой список книг",
    () => new Library("Адрес", [])
);


CatchError(
    "Проверяем на пустой элемент в списке книг",
    () => new Library("Адрес", [""])
);


CatchError(
    "Проверяем невозможность создания читателя с пустым именем",
    () => new Reader("", "Фамилия", 20)
);

CatchError(
    "Проверяем невозможность создания читателя с пустой фамилией",
    () => new Reader("Имя", "", 20)
);

CatchError(
    "Проверяем невозможность создания читателя с невалидным возрастом",
    () => new Reader("Имя", "Фамилия", 0)
);

CatchError(
    "Проверяем что возраст читателя не может-быть меньше 7-ми лет",
    () => new Reader("Имя", "Фамилия", 5)
);
Console.WriteLine("Нажмите любую кнопку для выхода");
Console.ReadKey();