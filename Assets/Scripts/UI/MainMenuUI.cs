using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playbutton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        playbutton.onClick.AddListener(OnClickPlayButton);

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });

        Time.timeScale = 1f;
    }

    private void OnClickPlayButton()
    {
        Loader.Load(Loader.Scene.GameScene);
    }

}
