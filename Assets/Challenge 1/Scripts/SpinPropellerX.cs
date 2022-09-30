//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float propeller = 1000;

    void Start()
    {
        
    }
    void Update()
    {
     transform.Rotate(Vector3.forward, propeller * Time.deltaTime);
   
    }
}
