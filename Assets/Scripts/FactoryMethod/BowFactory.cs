
// BowFactory.cs (Concrete Factory 2)
public class BowFactory : WeaponFactory
{
    public override IWeapon CreateWeapon()
    {
        return new Bow(); // Creates a Bow
    }
}



