using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject objectTarget;

    public float distanceToTargetX;

	// Use this for initialization
	void Start () {
        distanceToTargetX = transform.position.x - objectTarget.transform.position.x;
        Debug.Log(distanceToTargetX);
	}
	
	// Update is called once per frame
	void Update () {
        float targetObjectX = objectTarget.transform.position.x;

        Vector3 newPositionCamera = transform.position;

        newPositionCamera.x = targetObjectX + distanceToTargetX;

        transform.position = newPositionCamera;
	}
}
