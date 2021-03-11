using UnityEngine;
using System.Collections;

public class CameraRotator : MonoBehaviour
{
  
    public float speed = 1.0f;
    //SID: 1221628
    //This script is used to rotate the camera on the vehicle selection screen
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, -90, 0);
        }

    }
}

