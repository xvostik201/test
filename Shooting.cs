using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Transform firePoint1;
    public Transform firePoint2;
    public GameObject bullet;
    [SerializeField] KeyCode KeyShooting;
    public float nextTime = 0.0f;
    public float timeRate = 1f;
    public float lifetime = 3f;




    void Update()
    {
        lifetime -= 1 * Time.deltaTime;

        if (Input.GetKey(KeyShooting) && Time.time > nextTime && lifetime <= 0)
        {
            nextTime = Time.time + timeRate;

            Shoot();
        }

        

        void Shoot()
        {
            Instantiate(bullet, firePoint1.position, firePoint1.rotation);
            Instantiate(bullet, firePoint2.position, firePoint2.rotation);

        }

    }

}