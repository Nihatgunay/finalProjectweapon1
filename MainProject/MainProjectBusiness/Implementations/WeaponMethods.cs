using MainProjectBusiness.Interfaces;
using MainProjectCore;

namespace MainProjectBusiness.Implementations
{
    public class WeaponMethods : IWeaponMethods
    {
        private WeaponAK ak;
        public WeaponMethods(WeaponAK ak1)
        {
            ak = ak1;
        }

        public void Fire()
        {
            if (ak.Mode.Trim().ToLower() == "single")
            {
                Console.WriteLine("weapon cant fire in single mode");
            }
            else
            {
                if (ak.CurrentAmmo > 0)
                {
                    ak.CurrentAmmo = 0;
                    Console.WriteLine("You fired all the bullets");
                }
                else
                {
                    Console.WriteLine("no bullets left, please reload");
                }
            }
        }    
        public void Shoot()
        {
            if (ak.CurrentAmmo > 0)
            {
                ak.CurrentAmmo--;
                Console.WriteLine("shooted 1 bullet");
            }
            else
            {
                Console.WriteLine("no bullets left, please reload");
            }
        }

        public int GetRemainBulletCount()
        {
            return ak.CurrentAmmo;
        }

        public void Reload()
        {
            ak.CurrentAmmo = ak.MagSize;
            Console.WriteLine("weapon reloaded");
        }

        public void ChangeFireMode()
        {
            if (ak.Mode.Trim().ToLower() == "single")
            {
                ak.Mode = "auto";
                Console.WriteLine("Fire Mode has been changed to auto");
            }
            else
            {
                ak.Mode = "single";
                Console.WriteLine("Fire Mode has been changed to single");
            }
        }
    }
}
