using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkPerson : MonoBehaviour {

    public float speed = 5;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

	// Update is called once per frame
	void Update () {
        
        anim.
        transform.position += new Vector3(speed, 0, 0);
   
	}
}
