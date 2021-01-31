using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class spawnStar : MonoBehaviour {
     public GameObject star;
     public float starTimer;
     private float starIncr;

    void Awake() {
        starTimer = Time.time + starIncr;
    }

     void Update() {
         if (starTimer < Time.time) {
             float randX = UnityEngine.Random.Range(-4.4f, 4.4f);
             Debug.Log(string.Format("{0:N2}", randX));
             GameObject tmp = Instantiate(star, new Vector3(0.0f, 7.0f, 0.0f), Quaternion.identity);
             tmp.transform.position = new Vector3(randX, tmp.transform.position.y, 0.0f);
             starIncr = UnityEngine.Random.Range(5, 20);
             starTimer = Time.time + starIncr;
         }
         /** float randX = UnityEngine.Random.Range(-4.4f, 4.4f);
        Debug.Log(string.Format("{0:N2}", randX));
        GameObject tmp = Instantiate(enemy, new Vector3(0.0f, 7.0f, 0.0f), Quaternion.identity);
        tmp.transform.position = new Vector3(randX, tmp.transform.position.y, 0.0f); **/
     }
 }
