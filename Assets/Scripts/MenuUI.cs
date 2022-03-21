using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif




public class MenuUI : MonoBehaviour
{

    public InputField playerName;

    
    // Start is called before the first frame update
    void Start()
    {
        Profile.instance.ProfileUpdate();
        //Profile.ProfileUpdate(Profile.instance.ScoreTextOne);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewText(Text text)
    {
        Profile.instance.ScoreTextOne = text;
    }

   

    public void StartNew()
    {
        //Debug.Log("Best Score: " + playerName.text);
        Profile.playerProfile = playerName.text;
       

        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

        //Profile.instance.SaveText();

    }


    //public void SaveUserText()
    //{
    //    Profile.instance.SaveText();
    //}

    //public void LoadUserText()
    //{
    //    Profile.instance.LoadText();
    //    //Profile.instance.ProfileUpdate();

    //}
}
