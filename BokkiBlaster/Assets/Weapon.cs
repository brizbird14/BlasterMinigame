using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        // AYO TRY USING THE SPACE BAR IF YOU CAN LATER IT'S Input.GetKey(KeyCode.Space)
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot ()
    {
        // Shooting logic goes here
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
