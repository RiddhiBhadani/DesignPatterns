using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab; // Prefab to pool
    public int poolSize = 5;  // Number of objects in the pool

    private Queue<GameObject> poolQueue = new Queue<GameObject>();

    private void Start()
    {
        InitializePool();
    }

    private void InitializePool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false); // Deactivate initially
            poolQueue.Enqueue(obj);
        }
    }
    public GameObject GetObject()
    {
        if (poolQueue.Count > 0)
        {
            GameObject obj = poolQueue.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            Debug.LogWarning("Pool is empty! Consider increasing the pool size.");
            return null; //Return null if pool is not available
        }
    }

    public void ReturnObjectToPool(GameObject gameObject)
    {
        gameObject.SetActive(false);
        poolQueue.Enqueue(gameObject);
    }
}
