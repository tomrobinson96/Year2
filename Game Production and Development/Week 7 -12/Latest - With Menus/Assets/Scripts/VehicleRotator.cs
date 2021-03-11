using UnityEngine;
using System.Collections;

public class VehicleRotator : MonoBehaviour
{
    //The class is used to rotate the vehicles in the Vehicle selection screen
    //SID: 1221628
    public float speed = 1.0f;

    void Update()
    {
        transform.Rotate(Vector3.up, speed);
    }
}
