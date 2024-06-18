using MainProjectData;

namespace MainProjectCore
{
    public class WeaponAK
    {
        public string Name { get; set; }
        public int MagSize { get; set; }
        public int CurrentAmmo { get; set; }
        public string Mode { get; set; }
        public WeaponAK(int magsize, string mode)
        {
            Mode = mode;
            CurrentAmmo = magsize;
            MagSize = magsize;
            //if (mode.Trim().ToLower() != "single" || mode.Trim().ToLower() != "auto")
            //{
            //    throw new ModeException("Mode can only be single or auto");
            //}
            if (magsize <= 0)
            {
                throw new Exception("ammo cant be below 0");
            }
        }
    }
}
