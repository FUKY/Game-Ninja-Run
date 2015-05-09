using UnityEngine;
using System.Collections;

public class RandomMaps : MonoBehaviour {
    float subTime = 0.0f;

    public float distanceTime = 1.0f;

    float startTime = 0.0f;

    public GameObject[] ListobjectMaps;

	// Use this for initialization
	void Start () {
        Instantiate(ListobjectMaps[1], transform.position, transform.rotation);
	}

    //oldNum de xu ly viec trung lap 2 map lien tuc
    int oldeNum = 5;
	// Update is called once per frame
	void Update () {
        subTime = Time.time - startTime;
        if (subTime > distanceTime)
        {
            int num = RandomNum();
            //Debug.Log(num);
            Instantiate(ListobjectMaps[num ], transform.position, transform.rotation);
            //if (num == oldeNum)
            //{
            //    Instantiate(ListobjectMaps[num + 1], transform.position, transform.rotation);
            //    oldeNum = num + 1;
            //}
            //else
            //{
            //    Instantiate(ListobjectMaps[num], transform.position, transform.rotation);
            //    oldeNum = num;
            //}
            
            startTime = Time.time;

            
        }
	}

    private int RandomNum()
    {
        int numRand;
        numRand = Random.RandomRange(0, ListobjectMaps.Length);
        return numRand;
    }
}
