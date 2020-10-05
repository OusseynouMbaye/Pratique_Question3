using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D my_rigidbody;
    float playerSpeed = 400.0f;
   
    void Start()
    {
        my_rigidbody = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float inputVertical = Input.GetAxis("Vertical");
       // float inputFire  = Input.GetAxis("Fire");

        if (inputVertical !=0) {

            my_rigidbody.MovePosition(new Vector2(my_rigidbody.transform.position.x, Mathf.Clamp( my_rigidbody.transform.position.y + inputVertical ,-4.3f,4.3f)));
        
        }

        //if(inputFire != 0)
        //{
        //    ProcessFire();
        //}
    }
    void ProcessFire()
    {

    }
  
}
