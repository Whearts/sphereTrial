using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10;
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime *speed* verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime *speed* horizontalInput);
    
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
        }

        
    }   
}
