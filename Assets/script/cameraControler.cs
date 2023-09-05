using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour

{
    public float mouseSensitivity = 3.0f;
    private float rotationY;
    private float rotationX;
    public GameObject Player;
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float distanceFromTarget = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotationY += mouseX;
        rotationX += mouseY;
        rotationX = Mathf.Clamp(rotationX,-40,40);
        transform.localEulerAngles = new Vector3(rotationX,rotationY,0);
        transform.position = target.position - transform.forward * distanceFromTarget;
        
        
        
    }
}

