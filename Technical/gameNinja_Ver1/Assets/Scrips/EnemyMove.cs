using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

    bool isMove = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isMove)
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveMaps.mapMoveSpeed);
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            isMove = true;
        }

    }
}
