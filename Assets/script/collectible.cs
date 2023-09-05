using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class collectible : MonoBehaviour

{
    public GameManager gameManager;
    public int sphereValue;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Manager").GetComponent<GameManager>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other) {

        
        if (other.tag =="Player") {
            Destroy(this.gameObject);
            gameManager.UpdateSphere(sphereValue);
        }
        
        if (gameManager.sphere == 0) {
            gameManager.GameOver();
        }

        
    }
    
}
