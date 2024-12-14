
// Sword.cs (Concrete Weapon 1)
using UnityEngine;
public class Sword : IWeapon
{
    public void Attack()
    {
        Debug.Log("Swing the sword!");
    }
}
