
// Player.cs (Subject)
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 100;
    private List<IObserver> observers = new List<IObserver>();

    // Method to attach observers (e.g., health bar)
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    // Method to detach observers
    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    // Change player's health and notify observers
    public void ChangeHealth(int amount)
    {
        health += amount;
        NotifyObservers();
    }

    // Notify all attached observers
    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(health);
        }
    }
}
