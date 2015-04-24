using UnityEngine;
using System.Collections;

public class MoveMaps : MonoBehaviour {

    public static bool stopGame = false;

    public static float mapMoveSpeed = 5.0f;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (stopGame == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * mapMoveSpeed);
        }
        else
            mapMoveSpeed = 0.0f;
	}
}
