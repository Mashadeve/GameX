using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource soitin;

    private void Start()
    {
        soitin.volume = 0.5f;
        soitin.PlayDelayed(5f);
    }
}
