using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Spawnscript : MonoBehaviour {
     public GameObject enemy;
     public float spawnTimer;
     private float spawnIncr;

    void Awake() {
        spawnIncr = 2;
        spawnTimer = Time.time + spawnIncr;
    }

     void Update() {
         if (spawnTimer < Time.time) {
             float randX = UnityEngine.Random.Range(-4.4f, 4.4f);
             Debug.Log(string.Format("{0:N2}", randX));
             GameObject tmp = Instantiate(enemy, new Vector3(0.0f, 7.0f, 0.0f), Quaternion.identity);
             tmp.transform.position = new Vector3(randX, tmp.transform.position.y, 0.0f);
             spawnIncr = UnityEngine.Random.Range(0.75f, 6.0f);
             spawnTimer = Time.time + spawnIncr;
         }
         /** float randX = UnityEngine.Random.Range(-4.4f, 4.4f);
        Debug.Log(string.Format("{0:N2}", randX));
        GameObject tmp = Instantiate(enemy, new Vector3(0.0f, 7.0f, 0.0f), Quaternion.identity);
        tmp.transform.position = new Vector3(randX, tmp.transform.position.y, 0.0f); **/
     }
     

     
     /** public Vector3 GetRandomPoint()
     {
         int xRandom = 0;
         xRandom = (int)Random.Range(-4.5, 4.5);
         return new Vector3(xRandom, 0.0f);
         Vector3 randPosition = new Vector3(Random.Range(-4.5f, 4.5f), 7.0f, 0);
         // Instantiate(prefab, randPosition, Quaternion.identity);
         return randPosition;
     } **/
 
 }