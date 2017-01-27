using UnityEngine;
using System.Collections;
using System.Collections.Generic;
    //zonder de .generic ↑ kunnen we geen list maken.
    //"argument out of range" betekend dat er te weinig bool's zijn in de lijst

public class Test : MonoBehaviour {

    public List<bool> b = new List<bool>();

    // Use this for initialization
    void Start ()
    {
        //eerst wordt de lijst aangeroepen(b) en daarna het indexnummer (plek in de lijst)

            //hardcoded versie van een "for loop". for loop bestaat uit drie elementen, int i = 0 dit is de teller voor de computer zodat hij kan tellen hoevaak hij geloopt heeft.
            //in de resterende for looop procedure komt deze niet nogmaal voor.
            //de tweede i is de conditie die bepaalt of de computer nog een keer mag loopen. In dit geval mag hij dus 10x loopen (hij begint als 0).
            //i++ telt één bij i op. dan wordt de eerste i 1 en loopt hij nog een keer omdat het nog steeds kleiner is dan 10.
            //i staat in dit geval voor int, maar je mag elke naam gebruiken die je wilt, wij gebruiken de i omdat dit de eerste letter is van int.
            for (int i=0; i<10; i++)
            {
            if (b[i] == true)
                print("ik ben true");
            else print("ik ben niet true");
            }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}

//opdracht, in de forloop moet je checken of er een index op true staat. Als dit zo is dan print je "ik ben true"