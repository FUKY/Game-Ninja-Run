using UnityEngine;
using System.Collections;

public class CloudMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 15.0f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left*Time.deltaTime*2.0f);
	}
}
