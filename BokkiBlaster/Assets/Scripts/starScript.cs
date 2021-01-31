using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starScript : MonoBehaviour
{

    public float starSpeed = 20f;
    public Rigidbody2D rigidStar;

    // Start is called before the first frame update
    void Start()
    {
        rigidStar.velocity = -transform.up * starSpeed;
        //gameObject.tag = "Enemy";
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            Destroy(gameObject);
            //Debug.Log("Star broke");
        }
    }

}
