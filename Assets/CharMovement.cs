using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));
        Vector3 movement = new Vector3(0.0f,0.0f,0.0f);
        if(Input.GetButton("Horizontal")){
            print("horizontal");
            movement = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Horizontal")*-1);
        } else if(Input.GetButton("Vertical")){
            movement = new Vector3(Input.GetAxis("Vertical"),0.0f,Input.GetAxis("Vertical"));
            print("vertical");
        }
        print(movement);
        transform.position = transform.position + movement * Time.deltaTime;
    }
}
