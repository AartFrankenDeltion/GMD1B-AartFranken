using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//deze class geeft door aan de UIManager welke tekst op dat moment op het beeld moet komen.
//zodra je op een 'talk button' drukt dan wordt deze class getriggered.
//hij kijkt bij welke npc je op de button hebt gedrukt.
//dan duikt hij de class in, waar je een list met strings zal zien.
//Dan pakt hij een string eruit en deze geeft hij door aan de UIManager. 

//de volgorde is Dialog → ConversationManager → UIManager
public class ConversationManager : MonoBehaviour {

    public Dialog dialog;                   //dialog
    private int answer;                     //positive or negative
    public int cv;                          //conversation level
    public bool cs;                         //conversation started

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "NPC")
        {
            cs = true;
            dialog = col.gameObject.GetComponent<Dialog>();
            print(dialog.dialog[0] );       //begint bij de eerste (0) van de list
        }            
    }

    // Update is called once per frame
    void Update()                           //conversation level x knopwaarde = juiste antwoord
    {               
        if (cs==true)
        {                                   //positive
            if (Input.GetKeyDown("y"))
            {
                cv += 1;
                answer += 1;
                print(dialog.dialog[answer*cv]);
            }

                                            //negative
            if (Input.GetKeyDown("n"))
            {
                cv += 1;
                answer += 2;
                print(dialog.dialog[answer*cv]);
            }

        }

        if (answer>dialog.dialog.Count-1)
        {
            dialog = null;
        }
    }

}