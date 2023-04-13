using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hud : MonoBehaviour
{
    public Transform plane;
    public Text textG;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = plane.position.y;
        textG.text = plane.position.y.ToString();
    }
}
