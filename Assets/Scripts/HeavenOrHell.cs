using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeavenOrHell : MonoBehaviour
{
    public void Heaven()
    {
        SceneManager.LoadScene(2);
    }

    public void Hell()
    {
        SceneManager.LoadScene(3);
    }
}
