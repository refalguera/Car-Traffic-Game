using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodas : MonoBehaviour {

     public float velocidade;
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            this.transform.Rotate(velocidade * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("s"))
        {
            this.transform.Rotate(-velocidade * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("d"))
        {
            this.transform.Rotate(0, velocidade * Time.deltaTime, 0);

        }
        if (Input.GetKey("a"))
        {
            this.transform.Rotate(0, -velocidade * Time.deltaTime, 0);

        }
    }
}
