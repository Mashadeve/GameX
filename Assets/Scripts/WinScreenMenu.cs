using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenMenu : MonoBehaviour
{
    public GameObject WinMenu;
    public void LoadMenu()
    {
        WinMenu.SetActive(true);
        SceneManager.LoadScene("MainMenu");
    }
}
