using UnityEngine;
using System.Collections;

public class DestroyGameObject : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            Destroy(coll.gameObject);
            MoveMaps.stopGame = true;
        }
        else
            Destroy(coll.gameObject);
        
    }
}
