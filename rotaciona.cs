using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaciona : MonoBehaviour {
    public float velocidade;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(velocidade, 0, 0));
    }
}
