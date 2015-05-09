using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

    public GameObject enemy1;

    public GameObject enemy2;

    float subTime = 0.0f;
    float startTime = 0.0f;

    public float distanceTime = 2.0f;

    int numRandom;
	// Use this for initialization
	void Start () {
        randomEnemy();
	}
	
	// Update is called once per frame
	void Update () {

        //subTime = Time.time - startTime;

        //if (subTime > distanceTime)
        //{
        //    if (MoveMaps.stopGame == false)
        //    {
        //        randomEnemy();
        //        startTime = Time.time;
        //    }
        //}
	}

    void randomEnemy()
    {
        numRandom = Random.Range(0, 2);
        if (numRandom == 0)
        {
            Instantiate(enemy1, transform.position, transform.rotation);
        }
        else if (numRandom == 1)
        {
            Instantiate(enemy2, transform.position, transform.rotation);
        }
    }
}
