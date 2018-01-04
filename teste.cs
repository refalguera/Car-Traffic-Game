using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour {

    public float speed = 5f;
    public float rotateSpeed = 4f;
    bool grounded = false;
    Rigidbody myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (grounded == true)
        {
            myRigidBody.constraints = RigidbodyConstraints.FreezePositionY;
        }

        float forwardSpeed = Input.GetAxis("Vertical") * speed;
        transform.position += transform.forward * forwardSpeed * Time.deltaTime;
        float rotatecar = Input.GetAxis("Horizontal") * rotateSpeed;
        transform.Rotate(0, rotatecar, 0);

        grounded = false;
    }

    void OnCollisionEnter(Collision col)
    {
         if(col.gameObject.tag == "Ground")
        {
            grounded = true;
        }

        if(col.gameObject.tag == "Building"){

            print("Colidiu");
        }

    }
}
