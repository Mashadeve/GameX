using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeerSpawnManager : MonoBehaviour
{
    [SerializeField] TMP_Text beerCountText;
    public GameObject myPrefab;
    public int beerCount, currentBeerCount;
    private Vector3 Pos1, Pos2, Pos3, Pos4, Pos5;
    public bool canSpawn = true;

    private void Start()
    {
        currentBeerCount = beerCount;
        beerCountText.text = " X " + currentBeerCount;

        Pos1 = new Vector3(17, 0.5f, 0);
        Pos2 = new Vector3(65, -3, 0);
        Pos3 = new Vector3(100, -3, 0);
        Pos4 = new Vector3(200, 2, 0);
        Pos5 = new Vector3(300, 1, 0);

        for (int i = 0; i < beerCount; i++)
        {
            currentBeerCount++;
        }

    }

    private void FixedUpdate()
    {
        

        if (beerCount == 0 && canSpawn == true)
        {
            CloneBeer(Pos1);
            canSpawn = false;
  
        }
        if (beerCount == 1 && canSpawn == true)
        {
            CloneBeer(Pos2);
            canSpawn = false;
        }
        if (beerCount == 2 && canSpawn == true)
        {
            CloneBeer(Pos3);
            canSpawn = false;
        }
        if (beerCount == 3 && canSpawn == true)
        {
            CloneBeer(Pos4);
            canSpawn = false;
        }
        if (beerCount == 4 && canSpawn == true)
        {
            CloneBeer(Pos5);
            canSpawn = false;
        }
    }

    private void CloneBeer(Vector3 position)
    {
        Instantiate(myPrefab, position, Quaternion.identity);
    }

}
