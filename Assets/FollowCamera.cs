using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    [SerializeField] float camheight;
    // Camera position should be same as car postion



    void LateUpdate()
    {

        
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-3);
    }
}
