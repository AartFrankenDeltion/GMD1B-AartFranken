using System.Collections.Generic;
using UnityEngine;

public class lijst : MonoBehaviour {

    public List<GameObject> objects = new List<GameObject>();
    public List<GameObject> spawnedObjects = new List<GameObject>();
    public int i;
    public int i2;

	// Use this for initialization
	void Start ()
    {  
        //forloop, hij maakt eerst een teller aan. dan kijk hij of je int kleiner is dan 10, ja? dan begint het te lopen. 
        //daarna doet hij ++ en kijkt hij opnieuw of het groter dan 10 is en dan begint hij opnieuw.
        for (int i2 = 0; i2 < 10; i2++)
        {       
            //0=mimimum   objects.count=maximum
            i = Random.Range(0, objects.Count);
                                    //wat,                     waar(vector3 0,0,0),   rotatie
            spawnedObjects.Add((GameObject)Instantiate(objects[i], Vector3.zero, Quaternion.identity));
        }        
	}

	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
