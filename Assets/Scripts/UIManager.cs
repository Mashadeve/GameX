using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject playerHealth;
    [SerializeField] private GameObject pausePanel;   

    private void Awake()
    {

    }



    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void TakeDamage()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            playerHealth.GetComponent<Slider>().maxValue -= 10;
        }
    }
}
