using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody myrigidBody;

    void OnTriggerEnter(Collider col)
    {
        //print("Ok");
        if (col.gameObject.tag == "Enemy")
        {
            //col.rigidbody.
        }
    }

}
