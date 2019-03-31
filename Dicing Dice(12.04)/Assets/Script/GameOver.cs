using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public Text ScoreText;
    public Text ComboText;   
    public Text MissText;
    public Text rankText;
    GameManager GameManager;

    // Use this for initialization
    void Start () {
		
        ScoreText.text = ("" + PlayerPrefs.GetInt("Score"));       
        MissText.text = ("" + PlayerPrefs.GetInt("Miss"));
        ComboText.text = ("" + PlayerPrefs.GetInt("Combo"));

    }
	
	// Update is called once per frame
	void Update () {
        Rank();
       // StartCoroutine("Next");
    }


    void Rank()
    {
        if(PlayerPrefs.GetInt("Combo") > 500)
        {
            rankText.text = ("SSS");
        }
        else if(PlayerPrefs.GetInt("Combo") > 450)
        {
            rankText.text = ("SS");
        }
        else if (PlayerPrefs.GetInt("Combo") > 400)
        {
            rankText.text = ("S");
        }
        else if (PlayerPrefs.GetInt("Combo") > 300)
        {
            rankText.text = ("A");
        }
        else if (PlayerPrefs.GetInt("Combo") > 250)
        {
            rankText.text = ("B");
        }
        else if (PlayerPrefs.GetInt("Combo") > 200)
        {
            rankText.text = ("C");
        }
        else if (PlayerPrefs.GetInt("Combo") > 150)
        {
            rankText.text = ("D");
        }
        else if (PlayerPrefs.GetInt("Combo") > 100)
        {
            rankText.text = ("E");
        }
        else
        {
            rankText.text = ("F");
        }
    }
     
    IEnumerator Next()
    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene("Start");
    }
}
