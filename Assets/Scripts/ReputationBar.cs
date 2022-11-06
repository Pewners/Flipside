using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReputationBar : MonoBehaviour
{
    private float oldNegRep;
    private float negRep;

    private float oldPosRep;
    private float posRep;

    private bool newValue;

    public float difference;

    public Image redBar;
    public Image greenBar;

    public Choices choices;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        negRep = 0;
        posRep = 1;

        newValue = false;
    }

    // Update is called once per frame
    void Update()
    {
        redBar.fillAmount = negRep;
        greenBar.fillAmount = posRep;

        if (newValue)
        {
            if (choices.badTask)
            {
                //bad option
                newValue = false;
                difference = oldPosRep - posRep;
                negRep += difference;
            }

            if (!choices.badTask)
            {
                //good option
                newValue = false;
                difference = posRep - oldPosRep;
                negRep -= difference;
            }
        }
    }
}
