using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void OnPause()
    {
        pausePanel.SetActive(!pausePanel.activeSelf);

        if (pausePanel.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
