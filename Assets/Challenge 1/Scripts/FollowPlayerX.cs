//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E 26/09/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    //Cámara
    private Vector3 offset = new Vector3(30,0,10);

    void Start()
    {

    }

    void Update()
    {
        transform.position = plane.transform.position + offset ;
    }
}
