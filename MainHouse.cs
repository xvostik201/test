using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainHouse : MonoBehaviour
{

    public int HP = 1000;
    public Slider hpstat;
    public GameObject canvas;
    

    void Start()
    {
        GetComponent<Enemy>().HP = 150;
    }


    public void TakeDamage(int damage)
    {
        HP -= damage;
        hpstat.value = HP;

        if (HP <= 50)
        {

        }

        if (HP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        gameObject.SetActive(false);

    }
    void Update()
    {
      
    }
    void Respawn()
    {

    }

}
