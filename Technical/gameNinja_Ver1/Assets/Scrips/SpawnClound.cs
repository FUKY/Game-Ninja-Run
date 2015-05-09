using UnityEngine;
using System.Collections;

public class SpawnClound : MonoBehaviour {

    float subTime = 0.0f;

    public float distanceTime = 1.0f;

    float startTime = 0.0f;


    public GameObject objectCloud;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        subTime = Time.time - startTime;
        if (subTime > distanceTime)
        {
            Instantiate(objectCloud,transform.position,transform.rotation);
            startTime = Time.time;

        }
    }
}
