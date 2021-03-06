using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    public GameObject BoxText1; // makes a varable inside the inspector

    public GameObject HeaderText1; // makes a varable inside the inspector

   // public AudioSource clickSound;  // makes a varable inside the inspector 

    public GameObject thePanel; // makes a varable inside the inspector

    public void ClearText()
    {
        BoxText1.GetComponent<InputField>().text = "";  //clears the text in the inputfield
        HeaderText1.GetComponent<InputField>().text = "";  //same as above ^
        //clickSound.Play(); // plays sound assigned

    }

    public void CancelButton()
    {
        thePanel.SetActive(false);
    }

    public void CloseButton()
    {
        thePanel.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
