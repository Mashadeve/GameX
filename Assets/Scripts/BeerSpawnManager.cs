using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerSpawnManager : MonoBehaviour
{
    public GameObject myPrefab;
    public int beerCount;
    private Vector3 Pos1, Pos2, Pos3;
    public bool canSpawn = true;

    private void Start()
    {
        //Instantiate(myPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Pos1 = new Vector3(17, 0.5f, 0);
        Pos2 = new Vector3(65, -3, 0);
        Pos3 = new Vector3(100, -3, 0);

    }

    private void FixedUpdate()
    {
        Debug.Log("Beer count: " + beerCount);
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
    }

    private void CloneBeer(Vector3 position)
    {
        Instantiate(myPrefab, position, Quaternion.identity);
    }

}
