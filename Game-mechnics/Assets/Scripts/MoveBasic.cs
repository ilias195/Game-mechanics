using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 25f;
    [SerializeField] private float rotSpeed = 50f;
    
    private Rigidbody rb;
    
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow

        float moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down Arrow

        transform.position += new Vector3(moveX, 0, moveZ) * Time.deltaTime * speed;
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));

        /*
                Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
                transform.position = positionUpdate;



        */

        //  Vector3 moveHorizontal  = transform.position + Input.GetAxis("Horizontal") * transform.forward* speed * Time.deltaTime;
        //transform.position = moveHorizontal;

        // transform.Rotate(new Vector3(0, Input.GetAxis("Vertical") * rotSpeed * Time.deltaTime, 0));//



    }
}
