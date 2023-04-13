using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneBehaviour : MonoBehaviour
{
    public Transform plane;
    public float _forceSpeed;
    public float rotateSpeed;
    public float powerSpeed;
    public Vector3 _force;
    public KeyCode planeUp;
    public KeyCode planeDown;
    public Animator anim;
    public int HP; 
    public Slider hpstat;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        plane.position += _force;

        if (Input.GetKey(KeyCode.Q))
        {
            plane.Rotate(0, -rotateSpeed, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            plane.Rotate(0, rotateSpeed, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            _force += (plane.forward * Time.deltaTime) * _forceSpeed;
            anim.SetBool("isForward", true);
        }
        else
        {
            anim.SetBool("isForward", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _force += (-plane.forward * Time.deltaTime) * _forceSpeed;
            anim.SetBool("isBack", true);
        }
        else
        {
            anim.SetBool("isBack", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _force += (plane.right * Time.deltaTime) * _forceSpeed;
            anim.SetBool("isRight", true);
        }
        else 
        { 
            anim.SetBool("isRight", false); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            _force += (-plane.right * Time.deltaTime) * _forceSpeed;
            anim.SetBool("isLeft", true);
        }
        else
        {
            anim.SetBool("isLeft", false);
        }
        if (Input.GetKey(planeUp))
        {
            _force += (plane.up * Time.deltaTime) * powerSpeed;
        }
        if (Input.GetKey(planeDown))
        {
            _force += (-plane.up * Time.deltaTime) * powerSpeed;
        }
        else
        {
            _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime);
        }

        // HPslider 

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
        Destroy(gameObject);
    }
}
