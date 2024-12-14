using UnityEngine;
/*
 * WeaponFactory is an abstract factory because it defines the interface (CreateWeapon) for creating a weapon but does not specify which weapon.
SwordFactory and BowFactory are concrete factories because they provide specific implementations of the CreateWeapon method. 
The SwordFactory creates a Sword, while the BowFactory creates a Bow
 */

public class FactoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create weapon using Factory Method
        WeaponFactory swordFactory = new SwordFactory();
        IWeapon sword = swordFactory.CreateWeapon();
        sword.Attack();

        WeaponFactory bowFactory = new BowFactory();
        IWeapon bow = bowFactory.CreateWeapon();
        bow.Attack();
    }
}
