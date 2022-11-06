using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choices : MonoBehaviour
{
    public GameObject goodOption;
    public GameObject badOption;
    public GameObject goodText;
    public GameObject badText;
    public GameObject prompt;

    public bool goodTask;
    public bool badTask;

    private void Start()
    {
        prompt.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            goodOption.SetActive(true);
            prompt.SetActive(false);
            goodText.SetActive(false);
            badText.SetActive(false);
            goodTask = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            badOption.SetActive(true);
            prompt.SetActive(false);
            goodText.SetActive(false);
            badText.SetActive(false);
            badTask = true;
        }

        if (Input.GetMouseButtonDown(1))
        {
            goodText.SetActive(false);
            badText.SetActive(false);
        }
    }
}
