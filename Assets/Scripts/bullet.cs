using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision){
        Debug.Log("Hit");
        GameObject otherGameObject = collision.gameObject;
        Enemy hitEnemy = otherGameObject.GetComponent<Enemy>();

        if (hitEnemy != null)
        {

            hitEnemy.TakeDamage();
        }
        Destroy(gameObject);
    }

}
