




(string name, string surName, string login, byte loginLenght, bool pet, byte age, string[] favColor) anketa;

Console.Write("введи имя: ");
anketa.name = Console.ReadLine();

Console.Write("введи фамилию: ");
anketa.surName = Console.ReadLine();

Console.Write("введи логин: ");
anketa.login = Console.ReadLine();
anketa.loginLenght = (byte)anketa.login.Length;

Console.Write("есть питомец? (варианты ответа: да/нет) ");
anketa.pet = true;
string otvetProPet = Console.ReadLine();
switch (otvetProPet) 
{
    case "да":
        anketa.pet = true;
        break;
    case "нет":
        anketa.pet = false;
        break;
}
if (anketa.pet == true)
    otvetProPet = "питомец есть";
    else otvetProPet = "питомца нету";

Console.Write("сколько лет: ");
anketa.age = byte.Parse( Console.ReadLine());

Console.WriteLine("напиши три любимых цвета (после ввода каждого цвета необходимо нажать Enter):");
anketa.favColor = new string[3];
anketa.favColor[0] = Console.ReadLine();
anketa.favColor[1] = Console.ReadLine();
anketa.favColor[2] = Console.ReadLine();

Console.WriteLine("\n\nпривет {1} {0}!\nтвой логин {2}\nдлина логина {3} символов\n" + $"{otvetProPet}\n" + "тебе {4}\nтвои любимые цвета \n{5}\n{6}\n{7}",    
    anketa.name,anketa.surName, anketa.login, anketa.loginLenght, anketa.age, anketa.favColor[0], anketa.favColor[1], anketa.favColor[2]);





