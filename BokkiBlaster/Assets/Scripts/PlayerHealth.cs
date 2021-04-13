using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerHealth : MonoBehaviour
{
    
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public AudioSource audioOof;
    public fakeHealthBar bar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        audioOof = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    
    /* void Update()
    {
        Example code to test HealthBar function with space key lower health
         if(Input.GetKeyDown(KeyCode.Space))
         {
            TakeDamage(20);
    }
    */

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            TakeDamage(20);
            audioOof.Play();
        }
        if (col.gameObject.tag == "Whale")
        {
            TakeDamage(20);
            audioOof.Play();
        }
        if (col.gameObject.tag == "enemBullet")
        {
            TakeDamage(20);
            audioOof.Play();
        }
        if (col.gameObject.tag == "Star")
        {
            TakeDamage(-10);
        }
    }

    /** void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthBar.SetHealth(currentHealth);
    } **/
    void TakeDamage(int damage)
    {
        Debug.Log("Damage is: " + damage);
        currentHealth -= damage;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if(damage > 0) {
            bar.healthBarSet();
        }
        if(damage < 0) {
            bar.healthBarSetHeal();
        }
        Debug.Log("Current health: " + currentHealth);
    }
}
