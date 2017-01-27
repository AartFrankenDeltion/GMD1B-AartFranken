using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{

    public Vector3 spawn;
    public GameObject monster1;
    public GameObject monster2;
    public GameObject monster3;
    public float tijd;
    public List<int> am = new List<int>();


	// Use this for initialization
	void Update ()
    {
        SpawnMonster();
	}
	
	// Update is called once per frame
	public void SpawnMonster ()
    {
        tijd += Time.deltaTime;

        if (tijd >= 3)
        {
            GameObject groot = (GameObject)Instantiate(monster1, spawn, Quaternion.identity);
            tijd = 0;
        }

        

    }
}
