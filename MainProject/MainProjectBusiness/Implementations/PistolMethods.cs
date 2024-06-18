using MainProjectBusiness.Interfaces;
using MainProjectCore;

namespace MainProjectBusiness.Implementations
{
    public class PistolMethods : IPistolMethods
    {
        private WeaponPistol pistol;
        public PistolMethods(WeaponPistol pist)
        {
            pistol = pist;
        }
        public int GetRemainBulletCount()
        {
            return pistol.CurrentAmmo;
        }

        public void Reload()
        {
            pistol.CurrentAmmo = pistol.MagSize;
            Console.WriteLine("pistol reloaded");
        }

        public void Shoot()
        {
            if (pistol.CurrentAmmo > 0)
            {
                pistol.CurrentAmmo--;
                Console.WriteLine("shooted 1 bullet");
            }
            else
            {
                Console.WriteLine("no bullets left, please reload");
            }
        }
    }
}
