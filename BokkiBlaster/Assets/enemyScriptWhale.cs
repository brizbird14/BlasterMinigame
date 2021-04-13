using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScriptWhale : MonoBehaviour
{

    public float enemySpeed = 20f;
    public Rigidbody2D rigidEnemy;

    // Start is called before the first frame update
    void Start()
    {
        rigidEnemy.velocity = transform.right * enemySpeed;
        //gameObject.tag = "Enemy";
    }

}
