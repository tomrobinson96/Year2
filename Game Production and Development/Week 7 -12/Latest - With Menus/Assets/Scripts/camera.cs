//SID: 1431440
//This simple script keeps the camera just behind the object
using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject target;
    Vector3 camDistance;

    void Start()
    {
        //distance set between camera and object
        camDistance = transform.position - target.transform.position;

    }

    void LateUpdate()
    {
        //Late update to maintain the distance
        Vector3 cameraPosition = target.transform.position + camDistance;
        transform.position = cameraPosition;
    }
}
