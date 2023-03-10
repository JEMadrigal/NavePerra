using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    
    private void Update(){
        scoreText.text = "Score: " + score.ToString();
    }
   
}