using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour

{
    Rigidbody2D rb;
    [SerializeField]
    GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position + new Vector3(1,0,0), Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(4, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-4, 0, 0));
        }
    }
}
