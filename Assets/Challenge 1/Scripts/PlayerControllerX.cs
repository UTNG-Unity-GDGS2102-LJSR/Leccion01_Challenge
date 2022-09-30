//Sandoval Rodríguez Lendy Joanna 1219100438
//GDGS2102-E

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // Entrada vertical y horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Se indica que el avión se moverá hacia adelante a velocidad constante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Se indica que el avión se podrá mover hacia arriba y abajo
      transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * verticalInput * verticalInput);

     
    }
}
