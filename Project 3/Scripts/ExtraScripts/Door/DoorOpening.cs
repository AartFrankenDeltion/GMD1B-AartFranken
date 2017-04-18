using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour {

    public float timeLeft = 0;          //how long will it take to open the door.
    public RaycastHit hit;              //checks if there is a door within range.
    public Transform currentdoor;       //changes the rotation of the currentdoor.
    public bool open;                   //checks if the door is open or not.
    public bool IsOpeningDoor;          //if you're already opening one door, you can't open another door.
    public Transform cam;               //where you want to shoot the raycast from. (Firs person controller).
    public LayerMask mask;              //checks which layers ↑ can hit.

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E) && timeLeft == 0.0f)
            CheckDoor();

        if (IsOpeningDoor)
            openAndCloseDoor();
	}

    public void CheckDoor()
    {
        if (Physics.Raycast(cam.position, cam.forward, out hit, 5, mask))
        {
            open = false;
            if (hit.transform.localRotation.eulerAngles.y > 45)
            {
                open = true;
                IsOpeningDoor = true;
                currentdoor = hit.transform;
            }
        }
    }

    public void openAndCloseDoor()
    {
        timeLeft += Time.deltaTime;

        if (open)
            currentdoor.localRotation = Quaternion.Slerp(currentdoor.localRotation, Quaternion.Euler(0,0,0), timeLeft);
        else
            currentdoor.localRotation = Quaternion.Slerp(currentdoor.localRotation, Quaternion.Euler(0, 90, 0), timeLeft);

        if (timeLeft > 1)
        {
            timeLeft = 0;
            IsOpeningDoor = false;
        }
    }
}
