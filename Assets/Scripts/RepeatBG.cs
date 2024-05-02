using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{
    Vector3 startPosition; 
    float repeatVerticaly; 
    void Start()
    {
        startPosition = transform.position; //sätter startpositionen till positionen av objektet
        repeatVerticaly = GetComponent<BoxCollider2D>().size.y /2; //sätter reapeatVertically till din colliders storlek på y axeln och hittar mitten genom att dela den på 2
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < startPosition.y - repeatVerticaly) //objektet teleporteras 
        {
            transform.position = startPosition;
        }
    }
}
