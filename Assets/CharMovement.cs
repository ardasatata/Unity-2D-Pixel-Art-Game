using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float moveSpeed;
    public Animation charAnim;

    Vector3 vertical, horizontal;
    void Start()
    {
        vertical = Camera.main.transform.forward;
        vertical.y = 0;
        vertical = Vector3.Normalize(vertical);
        horizontal = Quaternion.Euler(new Vector3(0, 45, 0)) * vertical;
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"));
        // Vector3 movement = new Vector3(0.0f,0.0f,0.0f);
        // if(Input.GetButton("Horizontal")){
        //     print("horizontal");
        //     movement = new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Horizontal")*-1);
        // } else if(Input.GetButton("Vertical")){
        //     movement = new Vector3(Input.GetAxis("Vertical"),0.0f,Input.GetAxis("Vertical"));
        //     print("vertical");
        // } else if(Input.GetButton("Vertical")&&Input.GetButton("Horizontal")){
        //     print("combine");
        // }

        // print(movement);
        // print(Input.GetAxis("Vertical"));
        // print(Input.GetAxis("Horizontal"));
        // transform.position = transform.position + movement * Time.deltaTime;
        // if (Input.GetButton("Horizontal")||Input.GetButton("Vertical")){
        //     print("Move");
        //     Move();
        // }

        Vector3 vector3 = new Vector3(0.0f,0.0f,0.0f);
     
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {  
        vector3 += Vector3.forward;  
        }  
        if(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow)) {  
        vector3 += Vector3.back;  
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {  
        vector3 += Vector3.left;  
        }    
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {    
        vector3 += Vector3.right; 
        }  
        
        transform.Translate(moveSpeed * vector3.normalized * Time.deltaTime);
    }

    void Move(){
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        Vector3 horizontalMovement = horizontal * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        Vector3 verticalMovement = vertical * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        Vector3 heading = Vector3.Normalize(horizontalMovement + verticalMovement);

        transform.forward = heading;
        transform.position += horizontalMovement;
        transform.position += verticalMovement;
    }
}
