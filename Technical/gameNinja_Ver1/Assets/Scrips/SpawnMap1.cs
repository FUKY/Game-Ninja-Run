using UnityEngine;
using System.Collections;

public class SpawnMap1 : MonoBehaviour {

    float subTime = 0.0f;

    float startTime = 0.0f;

    public float DistanceTime = 3.0f;

    public GameObject maps;

    public static bool isInstance = true;
    // Use this for initialization
    void Start()
    {
        //Instantiate(maps, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        subTime = Time.time - startTime;
        if (subTime > DistanceTime && SpawnMap.isInstance == false )
        {
            if (MoveMaps.stopGame == false  )
            {
                Instantiate(maps, transform.position, transform.rotation);
                startTime = Time.time;
            }
        }
    }
}
