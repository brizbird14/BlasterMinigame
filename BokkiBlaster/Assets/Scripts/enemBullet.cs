﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

public class enemBullet : MonoBehaviour
{
    public float bulletSpeed = 20f;
    public float bulletHorz = 2.5f;
    public Rigidbody2D rb;
    public float despawnTime;
    private float despawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.up * bulletSpeed - transform.right*bulletHorz;

        despawnTimer = Time.time + despawnTime;
        //Debug.Log("Spawned bullet");
    }

    void Update() {
        if (despawnTimer < Time.time) {
            Destroy(gameObject);
            Debug.Log("DESPAWN BULLET");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            //Debug.Log("hit");
        }
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "PlatformHealth")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Platform")
        {
            Destroy(gameObject);
        }
    }
}

/**
    void OnTriggerEnger2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
**/
