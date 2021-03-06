using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    //This whole script saves the text inside the inputtext field each time the player pushes the save button

    //main text box
    public string boxText;

    public GameObject Note;

    public GameObject placeHolder;

    public AudioSource clickSound;
   
    
    
    public string NotesSaveFileName; //enter the savefile name for each page

    public string HeaderSaveFileName;

    //header text
    public string HeaderboxText;

    public GameObject HeaderNote;

    public GameObject HeaderplaceHolder;


    // Start is called before the first frame update
    void Start()
    {
        //at the start launch is gets the current save text
        boxText = PlayerPrefs.GetString(NotesSaveFileName);
        placeHolder.GetComponent<InputField>().text = boxText;

        HeaderboxText = PlayerPrefs.GetString(HeaderSaveFileName);
        HeaderplaceHolder.GetComponent<InputField>().text = HeaderboxText;
    }

   public void SaveNote()
    {
        //So each time the button is pressed it call this medhod to take the text currently in the box and saves it in the players files
        boxText = Note.GetComponent<Text>().text;
        PlayerPrefs.SetString(NotesSaveFileName, boxText);
        clickSound.Play();

    }


    public void SaveHeader()
    {
        HeaderboxText = HeaderNote.GetComponent<Text>().text;
        PlayerPrefs.SetString(HeaderSaveFileName, HeaderboxText);
        clickSound.Play();
    }



}
