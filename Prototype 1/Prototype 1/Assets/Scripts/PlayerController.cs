using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move the vehicle forward
        /* transform.Translate(0, 0, 1); */
        transform.Translate(Vector3.forward * Time.deltaTime* speed * verticalInput);
        
        /* Burda sadece obje sağa ve sola gidiyor bir dönme efekti yok.
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); */

        //turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
