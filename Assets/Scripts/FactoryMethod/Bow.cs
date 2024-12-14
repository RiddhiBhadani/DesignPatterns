// Bow.cs (Concrete Weapon 2)
using UnityEngine;
public class Bow : IWeapon
{
    public void Attack()
    {
        Debug.Log("Shoot an arrow!");
    }
}