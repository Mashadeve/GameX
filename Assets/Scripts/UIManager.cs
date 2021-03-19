using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public SceneManager sceneManager;
    void Start()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
    void Update()
    {
        
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Level_1");
    }
}
