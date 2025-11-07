using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Image pauseButtonImage;
    [SerializeField] private Sprite pauseSprite;
    [SerializeField] private Sprite playSprite;
 
    private bool isPaused;

    public void PauseButton() {
        if(isPaused) {
            isPaused = false;
            pauseButtonImage.sprite = pauseSprite;
            Time.timeScale = 1.0f;
        }
        else {
            isPaused = true;
            pauseButtonImage.sprite = playSprite;
            Time.timeScale = 0.0f;
        }
    }

    public void ExitButton() {
        Application.Quit();
    }
}
