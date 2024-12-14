/*
 The Player class is the Subject that maintains a list of observers (HealthBar in this case).
The HealthBar class is the Observer that reacts to changes in the player’s health by updating the UI.
The ObserverManager demonstrates how the subject and observer are connected, with the health bar automatically updating whenever the player’s health changes.
 */


// ObserverManager.cs (Client)
using UnityEngine;

public class ObserverManager : MonoBehaviour
{
    private Player player;
    private HealthBar healthBar;

    private void Start()
    {
        player = new Player();
        healthBar = new HealthBar();

        // Attach the health bar as an observer to the player
        player.Attach(healthBar);

        // Change health and notify observer (health bar)
        player.ChangeHealth(-20); // Health goes down by 20
        player.ChangeHealth(-30); // Health goes down by 30
    }
}