using UnityEngine;
using System.Collections;

public class SpawnMap : MonoBehaviour {

    float subTime = 0.0f;

    float startTime = 0.0f;

    public float DistanceTime = 3.0f;

    public GameObject maps;

    public static bool isInstance = true;

	// Use this for initialization
	void Start () {
        Instantiate(maps, transform.position, transform.rotation);

	}

    float countTime = 0.0f;
	// Update is called once per frame

    float fromTime = 5.0f;

    float toTime = 5.5f;
	void Update () {

        subTime = Time.time - startTime;

        countTime += Time.deltaTime;

        //Debug.Log(countTime);
        if (subTime > DistanceTime && isInstance == true)
        {
            if (MoveMaps.stopGame == false && isInstance == true)
            {
                Instantiate(maps, transform.position, transform.rotation);
               
                startTime = Time.time;
            }
        }

        if (countTime > fromTime && countTime < toTime)
        {
            isInstance = false;
        }
        else 
        {
            isInstance = true;
        }

	}

}
