using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform balLocation;
    Vector3 difference;
    void Start()
    {
        difference = transform.position - balLocation.position;
    }

    
    void Update()
    {
        if (BallMovement.fallof == false)
        {
           transform.position = balLocation.position + difference;
        }
        
    }
}
