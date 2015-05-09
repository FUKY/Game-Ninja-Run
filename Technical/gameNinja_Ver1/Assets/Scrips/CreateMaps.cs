using UnityEngine;
using System.Collections;

public class CreateMaps : MonoBehaviour {

    float subTime = 0.0f;

    float startTime = 0.0f;

    public float distanceTime = 4.0f;

    public GameObject[] ListObMaps;

    int count = 0;

	// Use this for initialization
	void Start () {
        Instantiate(ListObMaps[count],transform.position,transform.rotation);
        count++;
	}
	
	// Update is called once per frame
	void Update () {
        subTime = Time.time - startTime;
        if (subTime > distanceTime)
        {
            Instantiate(ListObMaps[count], transform.position, transform.rotation);

            count++;
            if (count > 2)
            {
                count = 0;
            }
            startTime = Time.time;
        }
	}
}
