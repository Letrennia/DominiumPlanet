Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Use up and down to navigate and press Enter to select");
Console.ResetColor();


ConsoleKeyInfo key;
ConsoleKeyInfo keyPlanet;
int option = 1;
bool isSelected = false;
(int left, int top) = Console.GetCursorPosition();
string color = "\u001b[32m";
string reset = "\u001b[0m";

Console.CursorVisible = false;

while (!isSelected)
{

    Console.SetCursorPosition(left, top);
    Console.WriteLine($"{(option == 1 ? color : "")}    Raport{reset}"); //to sa wydarzenia ktore sie wydarzyly + decyzje
    Console.WriteLine($"{(option == 2 ? color : "")}    Przeglad planet{reset}"); // przeglad ich statstyk
    Console.WriteLine($"{(option == 3 ? color : "")}    Decyzje{reset}"); // co moze gracz zrobic (nie musi podejmowac ktorejkolwiek jesli nie chce
    Console.WriteLine($"{(option == 4 ? color : "")}    Zakoncz ture{reset}");


    key = Console.ReadKey(true);


    switch (key.Key)
    {
        case ConsoleKey.DownArrow:
            {
                if (option == 4) option = 1;
                else option++;
                break;
            }
        case ConsoleKey.UpArrow:
            {
                if (option == 1) option = 4;
                else option--;
                break;
            }

        case ConsoleKey.Enter:
            {
                switch (option)
                {
                    case 1:
                        {


                            break;
                        }
                    case 2:
                        {
                            bool isSelectedPlanet = false;
                            int optionPlanet = 1;
                            //(int leftPlanet, int topPlanet) = Console.GetCursorPosition();
                            Console.Clear();

                            left = 0;
                            top = 0;
                            while (!isSelectedPlanet)
                            {
                                Console.SetCursorPosition(left, top);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Wybierz planete ktora chcesz zobaczyc");
                                Console.ResetColor();
                                Console.WriteLine($"{(optionPlanet == 1 ? color : "")}    Merkury{reset}");
                                Console.WriteLine($"{(optionPlanet == 2 ? color : "")}    Wenus{reset}");
                                Console.WriteLine($"{(optionPlanet == 3 ? color : "")}    Mars{reset}");
                                Console.WriteLine($"{(optionPlanet == 4 ? color : "")}    Ziemia{reset}");
                                Console.WriteLine($"{(optionPlanet == 5 ? color : "")}    Jowisz{reset}");
                                Console.WriteLine($"{(optionPlanet == 6 ? color : "")}    Saturn Uran Neptun{reset}");
                                Console.WriteLine($"{(optionPlanet == 7 ? color : "")}    Powrot{reset}");

                                keyPlanet = Console.ReadKey(true);
                                switch (keyPlanet.Key)
                                {
                                    case ConsoleKey.DownArrow:
                                        {
                                            if (optionPlanet == 7) optionPlanet = 1;
                                            else optionPlanet++;
                                            break;
                                        }
                                    case ConsoleKey.UpArrow:
                                        {
                                            if (optionPlanet == 1) optionPlanet = 7;
                                            else optionPlanet--;
                                            break;
                                        }
                                    case ConsoleKey.Enter:
                                        {
                                            Console.WriteLine($"wybrales opcje {optionPlanet}");
                                            break;
                                        }

                                }

                            }
                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case 4:
                        {
                            Environment.Exit(0);
                            break;
                        }


                }
                //isSelected = true;
                break;
            }

    }
}

