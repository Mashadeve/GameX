using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerSpawnManager : MonoBehaviour
{
    public GameObject myPrefab;
    private int beerCount;
    [SerializeField] Vector3 Pos1, Pos2;

    private void Start()
    {
        //Instantiate(myPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Pos1 = new Vector3(17, 0.5f, 0);
        Pos2 = new Vector3(65, -3, 0);
    }

    private void FixedUpdate()
    {
        if (beerCount == 0)
        {
            CloneBeer(Pos1);
            beerCount += 1;           
        }    
        
        if (beerCount == 1)
        {
            CloneBeer(Pos2);
            beerCount += 1;
        }
    }

    private void CloneBeer(Vector3 position)
    {
        Instantiate(myPrefab, position, Quaternion.identity);
    }

}
