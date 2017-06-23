using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{


    public GameObject InventoryPanel;
    [SerializeField]
    private bool isActive;

	void FixedUpdate ()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            isActive = !isActive;
        }
        if (isActive)
        {
            ActivateInventory();
        }
        if (!isActive)
        {
            DeactivateInventory();
        }
		
	}

    void ActivateInventory()
    {
        if(InventoryPanel.active == false)
        {
            InventoryPanel.SetActive(true);
        }
    }

    void DeactivateInventory()
    {
        if(InventoryPanel.active == true)
        {
            InventoryPanel.SetActive (false);
        }
    }
}
