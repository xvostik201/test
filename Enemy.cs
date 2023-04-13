using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.IO;

public class Enemy : MonoBehaviour
{

    public int HP = 100;
    public Slider hpstat;
    public GameObject canvas;

    void Start()
    {

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
