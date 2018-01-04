using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    int randEnemy;
    void Start () {
        StartCoroutine(waitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
	}
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            randEnemy = Random.Range(0, 2);
            Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, spawnValues.z);
            Instantiate(enemies[randEnemy], spawnPosition , gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);
                 
        }
    }
}
