using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // Get horizontal input (A/D or Left/Right arrow keys)
        forwardInput = Input.GetAxis("Vertical"); // Get vertical input (W/S or Up/Down arrow keys)
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
