// HealthBar.cs (Concrete Observer)
using UnityEngine;

public class HealthBar : IObserver
{
    public void Update(int health)
    {
        // Update the health bar UI (this is just a log in this case)
        Debug.Log("Health Bar updated: " + health);
    }
}