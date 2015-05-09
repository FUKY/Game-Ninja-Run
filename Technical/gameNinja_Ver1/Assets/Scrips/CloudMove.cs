using UnityEngine;
using System.Collections;

public class CloudMove : MonoBehaviour {


	void Start () {
        Destroy(gameObject, 15.0f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right*Time.deltaTime);
	}
}
