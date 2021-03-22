﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrunkScript : MonoBehaviour
{
    [SerializeField] Image pointer;
    private int end1, end2, currentPoints, beerPoints;
    public bool gotMoreBeer;
    // Start is called before the first frame update
    void Start()
    {
        end1 = -240;
        end2 = 240;

        StartCoroutine(Timer());
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gotMoreBeer);
        

        if (gotMoreBeer)
        {
            Debug.Log(gotMoreBeer);
            MoreDrunk(beerPoints);
        }
        
    }

    private void MoreDrunk(int beerPoints)
    {
        beerPoints = 10;
        pointer.GetComponent<RectTransform>().transform.position = new Vector2(pointer.GetComponent<RectTransform>().transform.position.x +
        pointer.GetComponent<RectTransform>().rect.width * beerPoints, pointer.GetComponent<RectTransform>().transform.position.y);
        currentPoints += beerPoints;
        gotMoreBeer = false;
        Debug.Log(gotMoreBeer);
    }

    private IEnumerator Timer()
    {
        currentPoints = 0;
        while (true)
        {
            Debug.Log(pointer.GetComponent<RectTransform>().rect.width);
            Debug.Log(currentPoints);
            yield return new WaitForSeconds(2f);
            currentPoints -= 5;
            pointer.GetComponent<RectTransform>().transform.position = new Vector2(pointer.GetComponent<RectTransform>().transform.position.x -
            pointer.GetComponent<RectTransform>().rect.width, pointer.GetComponent<RectTransform>().transform.position.y);


            if (currentPoints < end1)
            {
                Debug.Log("You arent drunk at all");
                break;
            }
            if (currentPoints > end2)
            {
                Debug.Log("You are way too drunk");
                break;
            }
        }
    }
}
