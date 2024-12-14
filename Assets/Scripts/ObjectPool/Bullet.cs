using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke(nameof(Deactivate), 2f); //Deactivate the bullet after certain amount of time
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Deactivate()
    {
        ObjectPool pool = FindObjectOfType<ObjectPool>();
        pool.ReturnObjectToPool(gameObject);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * 1f * Time.deltaTime);
    }
}
