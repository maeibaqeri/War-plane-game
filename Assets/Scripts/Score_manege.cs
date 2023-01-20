using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_manege : MonoBehaviour
{
    public int highScore;
    public static int LastScore=0;
    public int score=0;
    public Text scoreText;
    public Text HighScoreText;
    public Text LastScoreText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Score());
       
       highScore=PlayerPrefs.GetInt("high_score",0);
       
        
    }

    // Update is called once per frame
    void Update()
    {
       scoreText.text=score.ToString();
       
    }
    IEnumerator Score(){
    while (true)
    {
            yield return new WaitForSeconds(2);
         score=score+1;
      
        LastScore=score;
       
        
    }
    
        
    }


     IEnumerator Reload(){
    
    
            yield return new WaitForSeconds(10);
        SceneManager.LoadScene("game");
       
        
    
    
        
    }
}
