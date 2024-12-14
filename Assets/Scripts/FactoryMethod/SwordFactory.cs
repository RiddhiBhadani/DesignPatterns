// SwordFactory.cs (Concrete Factory 1)
public class SwordFactory : WeaponFactory
{
    public override IWeapon CreateWeapon()
    {
        return new Sword(); // Creates a Sword
    }
}