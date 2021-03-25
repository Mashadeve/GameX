using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PubManager : MonoBehaviour
{
    [SerializeField] PlayerController player;
    private bool ovi;

    void Start()
    {
        ovi = true;
    }

    
    void Update()
    {
               
         if (player.canMove == true && ovi == true)
         {
            GameObject.Find("Baari_ovi_kiinni").GetComponent<AudioSource>().Play();
            GameObject.Find("Baari_ovi_auki").SetActive(false);           
            ovi = false;
         }                    
    }
}
