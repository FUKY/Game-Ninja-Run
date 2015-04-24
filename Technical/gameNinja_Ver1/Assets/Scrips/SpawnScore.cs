using UnityEngine;
using System.Collections;

public class SpawnScore : MonoBehaviour {
	float subTime =0.0f;

	public float distanceTime = 3.0f;

	float startTime = 0.0f;

    public GameObject objectScore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		subTime = Time.time - startTime;
		if (subTime > distanceTime) {
            Instantiate(objectScore, transform.position, transform.rotation);
			startTime = Time.time;

		}
	}
}
