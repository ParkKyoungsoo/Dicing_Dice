using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;
    public Text ComboText;
    public Text Double;
    int Score = 0;
    int Combo = 0;
    int HighScore = 0;
    int doublescore = 1;
    int Miss = 0;
    int HighCombo = 0;


    void start()
    {
        
    }


    public void ScoreAdd()
    {
        Score = Score + (1000 * doublescore);
        ScoreText.text = (" " + Score);
    }
    

    public void combo()
    {
        HighCombo += 1;
        Combo += 1;
        if (Combo >= 30)
            doublescore = 4;
        else if (Combo >= 20)
            doublescore = 3;
        else if (Combo >= 10)
            doublescore = 2;
        else
            doublescore = 1;
        ComboText.text = (" " + Combo);
        Double.text = ("X" + doublescore);
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("Score", Score);
        PlayerPrefs.SetInt("Combo", HighCombo);
        PlayerPrefs.SetInt("Miss", Miss);
        if (PlayerPrefs.GetInt("HighScore") < Score)
        {
            PlayerPrefs.SetInt("HighScore", Score);
        }

        //PlayerPrefs.Save();
    }

    public void MissCount()
    {
        Miss += 1;
    }

    public void Resetcom()
    {
        Combo = 0;
        doublescore = 1;
        ComboText.text = (" " + Combo);
    }

    void Update()
    {             
       
    }



}
