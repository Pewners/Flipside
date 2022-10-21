using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    [SerializeField] private GameObject pressButton;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject dialogueText;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        pressButton.SetActive(false);
        visualCue.SetActive(false);
        dialoguePanel.SetActive(false);
        dialogueText.SetActive(false);
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
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            pressButton.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayDialogue();
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
            pressButton.SetActive(false);
        }
    }

    private IEnumerator PlayDialogue()
    {
        dialoguePanel.SetActive(true);
        yield return new WaitForEndOfFrame();
    }
}
