using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrunkScript : MonoBehaviour
{
    [SerializeField] Image pointer;
    private int end1, end2;
    // Start is called before the first frame update
    void Start()
    {
        end1 = -247;
        end2 = 247;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
