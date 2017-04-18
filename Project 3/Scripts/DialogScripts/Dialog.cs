using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//deze class zit op een 'npc' of wat dan ook.
//Hier staat een list in met strings van antwoorden.

    //de volgorde is Dialog → ConversationManager → UIManager
public class Dialog : MonoBehaviour {

    public List<string> dialog = new List<string>();

}