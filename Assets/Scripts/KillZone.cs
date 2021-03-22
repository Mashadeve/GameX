using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;
    void Start()
    {
        //player = PlayerController.Find("Player");
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(GameObject.Find("Player"));
        SceneManager.LoadScene("Level_1");
        player.playerAlive = false;
    }

    void Update()
    {
        
    }
    
    

}
