using PragueParkingDuo.Classes.Parking;
using PragueParkingDuo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PragueParkingGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            ParkingLot parkingLot = new ParkingLot();
            parkingLot.TryAddVehicle(new Car("ABC123"), out temp);
            //parkingLot.TryAddVehicle(new Mc ("ABC234"), out temp);
            //parkingLot.TryAddVehicle(new Mc ("ABC345"), out temp);
            //parkingLot.TryAddVehicle(new Car("ABC456"), out temp);
            //parkingLot.TryAddVehicle(new Trike("TRIKEMF"), out temp);
            //parkingLot.TryAddVehicle(new Bike("TRIKEBÅLLS"), out temp);
            //parkingLot.TryAddVehicle(new Bike("TRIKEB2LLS"), out temp);
            parkingLot.TryAddVehicle(new Bike("TRIKEB3LLS"), out temp);
            parkingLot.TryAddVehicle(new Car("AB453426"), out temp);
            parkingLot.TryAddVehicle(new Bike("TRIKE53235B3LLS"), out temp);
            parkingLot.TryAddVehicle(new Trike("Mmer"), out temp);
            parkingLot.TryAddVehicle(new Bike("fkuman"),out temp);
            //parkingLot.TryRemoveVehicle("ABC123", out temp);
            Console.WindowWidth = 160;

            //Console.SetWindowSize(Console.LargestWindowWidth,Console.LargestWindowHeight);



            char menu = ' ';
            do
            {
                // Format Setup
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("Prauge Parking OOB 2.0");
                drawParking(parkingLot, 1);
                Console.CursorTop = 26;
                Console.Write("1.Add Vehicle 2.Remove Vehicle 3.Search Vehicle 4.Move Vehicle 5.Show slots content");
                menu = Console.ReadKey().KeyChar.ToString().ToUpper().First();
                // Reading

                Console.Beep();
                if (menu == '1')
                {
                    clearLine();
                    Console.Write("1.Add Car 2.Add Trike 3.Add Mc 4.Add Bike");
                    Vehicle veh = new Vehicle();
                    bool succ = false;
                    int ind;
                    char menuV = Console.ReadKey().KeyChar;
                    if (menuV == '1' || menuV == '2' || menuV == '3' || menuV == '4')
                    {
                        clearLine();
                        Console.CursorVisible = true;
                        Console.Write("Input reg: ");
                        string reg = Console.ReadLine().Replace("\n","");
                        Console.CursorLeft = 0;
                        Console.CursorTop = Console.WindowHeight-2;
                        Console.CursorVisible = false;
                        if (Regex.IsMatch(reg.ToUpper(), @"^[a-zA-Z0-9]+$") && reg.Length < 25)
                        {
                            switch (menuV)
                            {
                                case '1': veh = new Car(reg); break;
                                case '2': veh = new Trike(reg); break;
                                case '3': veh = new Mc(reg); break;
                                case '4': veh = new Bike(reg); break;
                            }
                            succ = parkingLot.TryAddVehicle(veh, out ind);
                            if(succ == true)
                            {
                                clearLine();
                                Console.Write("Your vehicle {0} is parked at parkingspot {1}. Press any key to continue...", reg, ind + 1);
                                Console.CursorTop = Console.WindowHeight - 1;
                                Console.ReadKey();
                            }
                            else
                            {
                                clearLine();
                                Console.Write("Your vehicle did not park, maybe there is no space? Press any key to continue...");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            clearLine();
                            Console.Write("Your registration was not valid. Press any key to continue...");
                            Console.ReadKey();
                        }

                    }
                }
                if (menu == '2')
                {
                    clearLine();
                    Console.CursorVisible = true;
                    Console.Write("Input reg: ");
                    string reg = Console.ReadLine().Replace("\n", "");
                    bool succ = false;
                    int ind;
                    Console.CursorLeft = 0;
                    if (Regex.IsMatch(reg.ToUpper(), @"^[a-zA-Z0-9]+$") && reg.Length < 25)
                    {
                        succ = parkingLot.TryRemoveVehicle(reg, out ind);
                        if(succ == true)
                        {
                            clearLine();
                            Console.Write("Your vehicle {0} is no longer parked in slot {1}. Press any key to continue...", reg, ind + 1);
                            Console.CursorTop = Console.WindowHeight - 1;
                            Console.ReadKey();
                        }
                        else
                        {
                            clearLine();
                            Console.Write("Your vehicle was not found. Press any key to continue...");
                            Console.CursorTop = Console.WindowHeight - 1;
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        clearLine();
                        Console.Write("Your registration was not valid. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                if (menu == '3')
                {
                    clearLine();
                    Console.CursorVisible = true;
                    Console.Write("Input reg: ");
                    string reg = Console.ReadLine().Replace("\n", "");
                    bool succ = false;
                    int ind;
                    Console.CursorLeft = 0;
                    Console.CursorTop = Console.WindowHeight - 2;
                    if (Regex.IsMatch(reg.ToUpper(), @"^[a-zA-Z0-9]+$") && reg.Length < 25)
                    {
                        int spot = parkingLot.Search(reg);
                        if (spot >= 0)
                        {
                            clearLine();
                            Console.Write("Your vehicle is in slot {0}. Press any key to continue...", spot + 1);
                            Console.CursorTop = Console.WindowHeight - 1;
                            Console.ReadKey();
                        }
                        else
                        {
                            clearLine();
                            Console.Write("Your vehicle was not found. Press any key to continue...");
                            Console.CursorTop = Console.WindowHeight - 1;
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        clearLine();
                        Console.Write("Your registration was not valid. Press any key to continue...");
                        Console.ReadKey();
                    }

                }
                if (menu == '4')
                {
                    clearLine();
                    Console.CursorVisible = true;
                    Console.Write("Input reg: ");
                    string reg = Console.ReadLine().Replace("\n", "");
                    bool succ = false;
                    int ind;
                    Console.CursorLeft = 0;
                    Console.CursorTop = Console.WindowHeight - 2;
                    if (Regex.IsMatch(reg.ToUpper(), @"^[a-zA-Z0-9]+$") && reg.Length < 25)
                    {
                        clearLine();
                        Console.Write("Write the spot you want to move the vehicle to:");
                        int tospot = 0;
                        if (int.TryParse(Console.ReadLine(), out tospot) && tospot >= 1 && tospot <= 100)
                        {
                            tospot = tospot - 1;
                            if (tospot >= 0 && tospot < 100)
                            {
                                Console.CursorTop = Console.WindowHeight - 2;
                                succ = parkingLot.TryMove(reg, tospot);
                                if (succ == true)
                                {
                                    clearLine();
                                    Console.Write("Your vehicle {0} is now parked at slot {1}. Press any key to continue...", reg, tospot + 1);
                                    Console.CursorTop = Console.WindowHeight - 1;
                                    Console.ReadKey();
                                }
                                else
                                {
                                    clearLine();
                                    Console.Write("Your vehicle could not be moved or was not found. Press any key to continue...");
                                    Console.CursorTop = Console.WindowHeight - 1;
                                    Console.ReadKey();
                                }
                            }
                        }
                        else
                        {
                            clearLine();
                            Console.Write("You did not input a valid number. Press any key to continue...");
                            Console.CursorTop = Console.WindowHeight - 1;
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        clearLine();
                        Console.Write("Your registration was not valid. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                if (menu == '5')
                {
                    clearLine();
                    Console.Write("Write index you want to search:");
                    int tospot = 0;
                    if (int.TryParse(Console.ReadLine(), out tospot) && tospot >= 1 && tospot <= 100)
                    {
                        clearLine();
                        List<Vehicle> templ = parkingLot.Content()[tospot-1].Content();
                        Console.Write("Vehicles in parkingslot {0}: ", tospot);
                        foreach (Vehicle v in templ)
                        {
                            Console.Write(v.ToString() + " ");
                        }
                        Console.ReadKey();

                    }
                    else
                    {
                        clearLine();
                        Console.Write("You did not input a valid index. Press any key to continue...");
                        Console.CursorTop = Console.WindowHeight - 1;
                        Console.ReadKey();
                    }
                }

            } while (!menu.Equals('X'));
        }

        static void drawParking(ParkingLot lot, int y)
        {
            ParkingSlot[] slots = lot.Content();
            int counter = 0;
            int cTop = 0;
            for(int i = 0; i < slots.Length; i++)
            {
                Console.CursorTop = cTop + y;
                cTop++;
                if (cTop % 25 == 0) cTop = 0;
                if (i >= 25) Console.CursorLeft = 40;
                if (i >= 50) Console.CursorLeft = 80;
                if (i >= 75) Console.CursorLeft = 120;
                if (counter < 9) Console.Write(" ");
                if (counter < 99) Console.Write(" ");
                Console.Write(counter+1 + ">");
                counter++;
                string str = "";
                List<Vehicle> vehL = slots[i].Content();

                foreach(Vehicle veh in vehL)
                {
                    
                    string s = veh.ToString();
                    if (s.Length > 8)
                    {
                        s = s.Substring(0, 6);
                        s += "..";
                    }
                    str += s + ",";
                }
                if (str.EndsWith(",") == true) str = str.TrimEnd(',');

                Console.WriteLine(str);
            }
        }

        static void clearLine()
        {
            Console.CursorLeft = 0;
            Console.Write(String.Concat(Enumerable.Repeat(" ", 90)));
            Console.CursorLeft = 0;
        }

        static void drawRec(int x, int y, int width, int height, ConsoleColor c)
        {
            int tempL = Console.CursorLeft;
            int tempT = Console.CursorTop;
            ConsoleColor temp = Console.BackgroundColor;
            Console.BackgroundColor = c;
            for (int yi = y; yi < y+height; yi++)
            {
                for (int xi = x; xi < x+width; xi++)
                {
                    Console.CursorLeft = xi;
                    Console.CursorTop = yi;
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = temp;
            Console.CursorLeft = tempL;
            Console.CursorTop = tempT;
        }
    }
}
