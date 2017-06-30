using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightTorches : MonoBehaviour {

    public string activationNote = "Press SPACEBAR to activate torch";
    public Text activationText;
    public bool canLight;

    public GameObject litTorche;
    private GameObject litTorcheTwo;
    public CharController controller;
    public GameObject player;
    public AudioSource audioPlayer;

    public void Awake()
    {
        //Removes text from the UI Text, the rest are references to the player its components.
        activationText.text = null;
        player = GameObject.FindGameObjectWithTag("Player");
        audioPlayer = player.GetComponent<AudioSource>();
        controller = player.GetComponent<CharController>();
    }

    public void Update()
    {
        //Here it checks if you are in the radius of a torch and if the player has the statement needed to activate this function.
        //Furthermore it activates the audiocomponent of a GameObject with the "Player" tag.

        if (Input.GetButtonDown("Jump") && canLight == true && controller.gotLighter == true)
        {
            litTorcheTwo = (GameObject)Instantiate(litTorche, transform.position, transform.rotation);
            Destroy(gameObject);
            activationText.text = null;
            canLight = false;
            audioPlayer.Play();
        }
    }

    public void OnTriggerEnter(Collider o)
    {
        // Here it checks if the object with the ontriggerenter if it has this name specific tag, and if the player
        // also got the lighter, then it will activate the following function.
        if(o.transform.tag == "Player" && controller.gotLighter == true) 
        {
            activationText.text = activationNote.ToString();
            canLight = true;
        }
    }

    public void OnTriggerExit(Collider o)
    {
        // Upon leaving the OnTriggerEnter zone it removes the string from the Text thats on the canvas.
            activationText.text = null;
    }
}
