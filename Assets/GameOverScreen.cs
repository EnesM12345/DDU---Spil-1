using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOverScreen : MonoBehaviour
{
    public TMP_Text pointsText;

    public void Setup(int score){
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "Time";
    }

    public void RestartButton(){
        SceneManager.LoadScene("Game");
        }

    
    public void ExitButton() {
        SceneManager.LoadScene("MainMenu");
        }
}
