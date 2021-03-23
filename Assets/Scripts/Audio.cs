using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioSource rumpu;
    // Start is called before the first frame update
    void Start()
    {
        rumpu = GetComponent<AudioSource>();
        rumpu.volume = 0.2f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
