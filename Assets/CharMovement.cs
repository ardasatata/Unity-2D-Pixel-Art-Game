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
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"),0.0f,0.0f);
        Vector3 vertical = new Vector3(0.0f,0.0f,Input.GetAxis("Vertical"));
        transform.position = transform.position + horizontal + vertical * Time.deltaTime;
    }
}
