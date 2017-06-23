using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    [SerializeField]
    private ItemDatabase iDatabase;

	
	// Update is called once per frame
	void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            if (Input.GetMouseButtonDown(0) && hit.collider.tag == "Wood")
            {
                foreach (Item i in iDatabase.InventoryDat)
                {
                    if(i.itemName == hit.collider.tag)
                    {
                        i.itemAmount += Random.Range(0, 10);
                        Destroy (hit.collider.gameObject);
                    }
                }
            }
        }
		
	}
}
