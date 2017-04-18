using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour {
    //BELANGRIJK
    //Dit script kijkt naar welke items de "PickUpTag" script hebben. En verder hoe je iets kunt oppakken en droppen.

    GameObject mainCamera;
    bool carrying;                      //ben je aan het dragen
    GameObject carriedObject;           //wat je aan het dragen bent.
    public float distance;              //dit kijkt of je dichtbij genoeg bent om te dragen.
    public float smooth;                //soort delay van het gedragen object ten opzichte van je muis.

    // Use this for initialization
    void Start ()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
	}

    // Update is called once per frame
    void Update()
    {
        if (carrying)
        {
            carry(carriedObject);
            checkDrop();
        }
        else
        {
            pickUp();
        }
    }

    void carry (GameObject go)
    {
        go.transform.position = Vector3.Lerp (go.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime*smooth);
    }

    void pickUp()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;
            Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                PickUpTag put = hit.collider.GetComponent<PickUpTag>();
                if (put != null)
                {
                    carrying = true;
                    carriedObject = put.gameObject;
                    put.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
    }

    void checkDrop()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dropObject();
        }
    }

    void dropObject()
    {
        carrying = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        carriedObject = null;
    }
}
