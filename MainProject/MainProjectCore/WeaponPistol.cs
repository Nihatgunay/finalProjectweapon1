using MainProjectData;

namespace MainProjectCore
{
    public class WeaponPistol
    {
        public string Name { get; set; }
        public int MagSize { get; set; }
        public int CurrentAmmo { get; set; }
        public WeaponPistol(int magsize)
        {
            MagSize = magsize;
            CurrentAmmo = magsize;
            if (magsize <= 0)
            {
                throw new Exception("ammo cant be below 0");
            }
        }
    }
}
