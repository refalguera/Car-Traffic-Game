using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

    public void ChangesScenes2(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
