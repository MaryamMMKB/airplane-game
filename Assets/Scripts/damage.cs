using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int hp = 3;
    // Start is called before the first frame update
    public void TakeDamage()
    {
        hp -= 1;
        if (hp == 0)
        {
            Destroy(gameObject);
        }
    }
    
}
