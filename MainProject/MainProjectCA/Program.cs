using MainProjectBusiness.Implementations;
using MainProjectBusiness.Interfaces;
using MainProjectCore;


namespace MainProjectCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter weapon:  ");
                string weaponchoice = Console.ReadLine();

                WeaponPistol pistol = new(16);
                IPistolMethods pistolmethod = new PistolMethods(pistol);

                if (weaponchoice.Trim().ToLower() == "ak47")
                {
                    Console.Write("weapon mode:  ");
                    string akmode = Console.ReadLine();
                    WeaponAK weaponak = new WeaponAK(30, akmode);
                    IWeaponMethods weaponmethods = new WeaponMethods(weaponak);
                    if (akmode.Trim().ToLower() == "single" || akmode.Trim().ToLower() == "auto")
                    {
                        while (true)
                        {

                            Console.WriteLine("0. Get Information");
                            Console.WriteLine("1. Shoot");
                            Console.WriteLine("2. Fire");
                            Console.WriteLine("3. GetRemaingBulletCount");
                            Console.WriteLine("4. Reload");
                            Console.WriteLine("5. Changefiremode");
                            Console.WriteLine("6. Exit Program");
                            Console.WriteLine("7. Change mag size");

                            Console.WriteLine("Enter your choice: ");
                            int choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 0:
                                    Console.WriteLine($"Fire Mode -- {weaponak.Mode}  Mag size -- {weaponak.MagSize}  Current ammo -- {weaponak.CurrentAmmo}");
                                    break;
                                case 1:
                                    weaponmethods.Shoot();
                                    break;
                                case 2:
                                    weaponmethods.Fire();
                                    break;
                                case 3:
                                    Console.WriteLine($"current ammo - {weaponmethods.GetRemainBulletCount()}");
                                    break;
                                case 4:
                                    weaponmethods.Reload();
                                    break;
                                case 5:
                                    weaponmethods.ChangeFireMode();
                                    break;
                                case 6:
                                    return;
                                case 7:
                                    Console.Write("Enter new mag size: ");
                                    int magchoice = int.Parse(Console.ReadLine());
                                    if (magchoice > 0)
                                    {
                                        weaponak.MagSize = magchoice;
                                        Console.WriteLine($"mag size is set to {weaponak.MagSize}");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("choose between 0-6");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no such a mode");
                    }
                }
                if (weaponchoice.Trim().ToLower() == "pistol")
                {
                    while (true)
                    {

                        Console.WriteLine("0. Get Information");
                        Console.WriteLine("1. Shoot");
                        Console.WriteLine("2. GetRemainingBulletCount");
                        Console.WriteLine("3. Reload");
                        Console.WriteLine("4. Exit Program");

                        Console.WriteLine("Enter your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 0:
                                Console.WriteLine($"Mag size -- {pistol.MagSize}  Current ammo -- {pistol.CurrentAmmo}");
                                break;
                            case 1:
                                pistolmethod.Shoot();
                                break;
                            case 2:
                                Console.WriteLine($"current ammo - {pistolmethod.GetRemainBulletCount()}");
                                break;
                            case 3:
                                pistolmethod.Reload();
                                break;
                            case 4:
                                return;
                                break;
                            default:
                                Console.WriteLine("choose between 0-4");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("There is no such a weapon in this project");
                }
            }
        }
    }
}
