using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;  // Position to spawn the object
    private ObjectPool objectPool;
    private float randomRange = 5;

    private void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonUp(0)) // Left mouse
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = objectPool.GetObject();
        if (bullet != null)
        {
            // Set bullet start position
            bullet.transform.position = firePoint.position;

            // Calculate a random position within a specified range
            Vector3 randomOffset = new Vector3(
                Random.Range(-randomRange, randomRange), // Random X
                Random.Range(-randomRange, randomRange), // Random Y
                0f                                      // Keep Z constant
            );

            // Set the direction towards the random offset
            Vector3 targetPosition = firePoint.position + firePoint.forward * 10f + randomOffset;
            bullet.transform.LookAt(targetPosition); // Rotate bullet to face target

            // Apply bullet motion in its forward direction (handled in Bullet script)
        }
    }
}
