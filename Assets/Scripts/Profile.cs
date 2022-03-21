using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Profile : MonoBehaviour
{
    public static Profile instance;

    public int playerScore;
    public static string playerProfile;
    public Text ScoreTextOne;
  
    private void Awake()
    {
        instance = this;
        if (PlayerPrefs.HasKey("ScoreTextOne"))
        {
            playerScore = PlayerPrefs.GetInt("ScoreTextOne");
            
            ScoreTextOne.text = playerScore.ToString();
            ScoreTextOne.text = playerProfile;
        }
        //LoadText();
        PlayerPrefs.Save();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProfileUpdate()
    {
        
        playerScore = MainManager.m_Points;

        ScoreTextOne.text = playerScore.ToString();
        
        ScoreTextOne.text = "Best Score: " + playerProfile + " : " +  playerScore.ToString();

        PlayerPrefs.SetInt("ScoreTextOne", playerScore);
        PlayerPrefs.SetString("ScoreTextOne", playerProfile);
        
    }

    public void ClearScore()
    {
        PlayerPrefs.DeleteKey("ScoreTextOne");
        playerScore = 0;
        ScoreTextOne.text = playerScore.ToString();
    }

    //[System.Serializable]
    //class SaveData
    //{
    //    public Text ScoreTextOne;
    //}

    //public void SaveText()
    //{
    //    SaveData data = new SaveData();
    //    data.ScoreTextOne = ScoreTextOne;

    //    string json = JsonUtility.ToJson(data);

    //    File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    //}

    //public void LoadText()
    //{
    //    string path = Application.persistentDataPath + "/savefile.json";
    //    if (File.Exists(path))
    //    {
    //        string json = File.ReadAllText(path);
    //        SaveData data = JsonUtility.FromJson<SaveData>(json);

    //        ScoreTextOne = data.ScoreTextOne;
    //    }
    //}
}
