using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskScript : MonoBehaviour
{
    public GameObject player;
    public DialogueManager dialogueManager;

    bool goodTask;
    bool taskAccepted;

    public Image backDrop;
    public Text taskInstructions;
    float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueManager.choicesDisplayed)
        {
            //dialogueManager.
        }
    }
}
