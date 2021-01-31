using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public float enemySpeed = 20f;
    public Rigidbody2D rigidEnemy;
    public int rocketHealth;

    // Start is called before the first frame update
    void Start()
    {
        rigidEnemy.velocity = -transform.up * enemySpeed;
        //gameObject.tag = "Enemy";
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            Destroy(gameObject);
        }
    }

}
