using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AASworking : MonoBehaviour
{
    public Text enterText;
    public GameObject player;
    public EnemyTargetScript scriptName;

    // player.transform = positionSeat.transform








    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            scriptName.enabled = false;
            enterText.gameObject.SetActive(false);
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            scriptName.enabled = true;
            enterText.gameObject.SetActive(true);
        }
    }

}
