using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public float time = 0f;
    public float speed = 5f;
    public Rigidbody rb;
    public int damage = 1;
    void Start()
    {

        {
            rb.velocity = transform.forward * speed;
            DestroyObjectDelayed();
        }

    }
    private void OnTriggerEnter(Collider collision)
    {
         PlaneBehaviour planeBehaviour = collision.GetComponent<PlaneBehaviour>();
         if (planeBehaviour != null)
         {
            planeBehaviour.TakeDamage(damage);
            Destroy(gameObject);
         }

    }
    void DestroyObjectDelayed()
    {
        Destroy(gameObject, time);
    }
}
