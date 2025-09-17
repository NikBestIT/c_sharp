using KT1N;

var library = new Library("Адрес", ["Преступление и наказание", "Война и мир", "Щелкунчик"]);

var nikita = new Reader("Никита", "Бестфатор", 18);

nikita.ReadBook(library, "Щелкунчик");

nikita.ReadBook(library, "Звездные войны");