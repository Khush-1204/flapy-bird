using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class logic : MonoBehaviour
{
    public int Score;
    public Text scoretext;
    public GameObject gameoverbar;

    public void addscore(int scoretoadd)
    {
        Score = Score + scoretoadd;
        scoretext.text = Score.ToString();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }

    public void gameover()
    {
        gameoverbar.SetActive(true);
    }
 
}
