using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botao : MonoBehaviour {

    public Button restartbutton;

	// Use this for initialization
	void Start () {

        GameObject.Find("Restart").GetComponentInChildren<Text>().text = "RESTART";

    }
}
