using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBG : MonoBehaviour
{
    public float speed = 10f; //best�m hur snabbt din bakgrund ska r�ra p� sig
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        // vilken axel den ska r�ra sig p�
    }
}
