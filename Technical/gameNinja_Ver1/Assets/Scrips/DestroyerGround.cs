using UnityEngine;
using System.Collections;

public class DestroyerGround : MonoBehaviour {

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
