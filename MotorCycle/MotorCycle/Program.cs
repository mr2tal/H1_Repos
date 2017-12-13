using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.PrintMenu();
        }
    }
    class Menu
    {

        MotorCycle m = new MotorCycle();
        public void PrintMenu()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine(m.ToString());
                Console.WriteLine("Welcome to motorcycle");
                Console.WriteLine("1. start/stop engine");
                Console.WriteLine("2. Set RPM");
                Console.WriteLine("3. Shift up gear");
                Console.WriteLine("4. Shift down gear");
                Console.WriteLine("5. Set Name");
                Console.WriteLine("6. exit");

                string input = Console.ReadLine();
                MenuChoice(input);

            }
        }
        public void MenuChoice(string input)
        {
            switch (input)
            {
                case "1":
                    if (m.GetStarted() == true)
                    {
                        m.Stop();
                    }else
                    {
                        m.Start();
                    }
                    break;
                case "2":
                    Console.WriteLine("Input RPM");
                    string inputRPM = Console.ReadLine();
                    int.TryParse(inputRPM, out int RPM);
                    m.SetRPM(RPM);
                    break;
                case "3":
                    m.ShiftGearUp();
                    break;
                case "4":
                    Console.WriteLine("input gear");
                    string inputGear = Console.ReadLine();
                    int.TryParse(inputGear, out int gear);
                    m.ShiftGearDown(gear);
                    break;
                case "5":
                    Console.WriteLine("Input Name");
                    string inputName = Console.ReadLine();
                    m.SetName(inputName);
                    break;
                case "6":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;

            }
        }

    }
    class MotorCycle
    {
        //fields
        private bool _started;
        private int _rpm;
        private int _gear;
        private string _name;

        //getset methods
        public bool GetStarted()
        {
            return _started;
        }
        public void SetStarted(bool s)
        {
            _started = s;
        }
        public int GetRPM()
        {
            return _rpm;
        }
        public void SetRPM(int rpm)
        {
            if (rpm >= 1000 && rpm <= 8000 && GetStarted() == true)
            {
                _rpm = rpm;
            }
            else if (rpm < 1000 && GetStarted() == true)
            {
                SetStarted(false);
                _rpm = 0;
            } else if (rpm > 8000 && GetStarted() == true)
            {
                _rpm = 8000;
            } else if (GetStarted() == false)
            {
                _rpm = 0;
            }
        }
        public int GetGear()
        {
            return _gear;
        }
        public void SetGear(int g)
        {
            _gear = g;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string n)
        {
            _name = n;
        }

        //Constructor
        public MotorCycle()
        {
            SetStarted(false);
            SetRPM(0);
            SetGear(0);
            SetName("");
        }
        public MotorCycle(bool s, int rpm, int g, string n)
        {
            SetStarted(s);
            SetRPM(rpm);
            SetGear(g);
            SetName(n);
        }

        //methods
        public void Start()
        {
            SetStarted(true);
            SetRPM(1000);
            SetGear(0);
        }
        public void Stop()
        {
            SetStarted(false);
            SetRPM(0);
            SetGear(0);
        }
        public double GetSpeed()
        {
            double speed = GetRPM() * (GetGear() / 200.00);
            return speed;
        }
        public void ShiftGearUp()
        {
            if (GetGear() < 5 && GetGear() >= 0)
            {
                SetGear(GetGear() + 1);
            }
        }
        public void ShiftGearDown(int g)
        {
            if (g < GetGear() && g >= 0 && g <= 5)
            {
                SetGear(g);
            }else
            {
                Console.WriteLine("kan ikke skifte gear");
            }
        }
        public override string ToString()
        {
            return string.Format("Isstarted: {0} , RPM: {1} , Gear: {2}, Name: {3}, Speed: {4}", GetStarted(), GetRPM(), GetGear(), GetName(), GetSpeed());
        }

    }
}
