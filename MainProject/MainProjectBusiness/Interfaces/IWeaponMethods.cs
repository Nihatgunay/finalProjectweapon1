namespace MainProjectBusiness.Interfaces
{
    public interface IWeaponMethods
    {
        public void Shoot();
        public void Fire();
        public int GetRemainBulletCount();
        public void Reload();
        public void ChangeFireMode();
    }
}
