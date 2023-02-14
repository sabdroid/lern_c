Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if (username == "Женя")
  {
    Console.WriteLine("Добро пожаловать!");
  }
else
  {
    Console.Write("Впервые слышу о тебе," + (username));
  }
