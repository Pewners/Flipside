using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;

    private dialogueManager dialogueManager;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void Update()
    {
        dialogueManager = GetComponent<dialogueManager>();
        if (playerInRange)
        {
            visualCue.SetActive(true);
            //if (InputManager.GetInstance().GetInteractPressed())
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            }
        }

        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
