using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTargetScript : MonoBehaviour
{
    public Transform[] targets;
    public Transform tower;
    public Transform firePoint;
    public GameObject bullet;
    public float nextTime = 0.0f;
    public float timeRate = 1f;
    public Transform target;
    public float timeChange;
    public float lifetime = 3f;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.transform.position - tower.transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        tower.transform.rotation = Quaternion.Lerp(tower.transform.rotation, rotation, speed * Time.deltaTime);

        lifetime -= 1 * Time.deltaTime;

        


        if (Time.time > nextTime && lifetime <= 0)
        {
            nextTime = Time.time + timeRate;
            Shoot();
            Invoke("ChangeTarget", timeChange);
        }

        void Shoot()
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }
    public void ChangeTarget()
    {
        target = targets[Random.Range(0, targets.Length)];
    }
}
