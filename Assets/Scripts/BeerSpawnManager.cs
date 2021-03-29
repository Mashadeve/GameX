using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeerSpawnManager : MonoBehaviour
{
    [SerializeField] TMP_Text beerCountText;
    public GameObject[] myPrefab;
    public GameObject[] myPrefabClone;
    public int beerCount, currentBeerCount;
    private Vector3 Pos1, Pos2, Pos3, Pos4, Pos5, Pos6, Pos7, Pos8, Pos9, Pos10, Pos11, Pos12;
    public bool canSpawn = true;

    private void Start()
    {
        Pos1 = new Vector3(17, 0.5f, 0);
        Pos2 = new Vector3(50, -1, 0);
        Pos3 = new Vector3(65, -3, 0);
        Pos4 = new Vector3(80, -3, 0);
        Pos5 = new Vector3(100, -1.3f, 0);
        Pos6 = new Vector3(173, 6, 0);
        Pos7 = new Vector3(200, 1, 0);
        Pos8 = new Vector3(250, 1, 0);
        Pos9 = new Vector3(300, 1, 0);
        Pos10 = new Vector3(350, 1, 0);
        Pos11 = new Vector3(400, 1, 0);
        Pos12 = new Vector3(480, 1, 0);
        

        myPrefabClone[0] = Instantiate(myPrefab[0], Pos1, Quaternion.identity);
        myPrefabClone[1] = Instantiate(myPrefab[0], Pos2, Quaternion.identity);
        myPrefabClone[2] = Instantiate(myPrefab[0], Pos3, Quaternion.identity);
        myPrefabClone[3] = Instantiate(myPrefab[0], Pos4, Quaternion.identity);
        myPrefabClone[4] = Instantiate(myPrefab[0], Pos5, Quaternion.identity);
        myPrefabClone[5] = Instantiate(myPrefab[0], Pos6, Quaternion.identity);
        myPrefabClone[6] = Instantiate(myPrefab[0], Pos7, Quaternion.identity);
        myPrefabClone[7] = Instantiate(myPrefab[0], Pos8, Quaternion.identity);
        myPrefabClone[8] = Instantiate(myPrefab[0], Pos9, Quaternion.identity);
        myPrefabClone[9] = Instantiate(myPrefab[0], Pos10, Quaternion.identity);
        myPrefabClone[10] = Instantiate(myPrefab[0], Pos11, Quaternion.identity);
        myPrefabClone[11] = Instantiate(myPrefab[0], Pos12, Quaternion.identity);
        



    }
    private void Update()
    {
        beerCountText.text = beerCount.ToString("0");
    }

    private void FixedUpdate()
    {
        

        //if (beerCount == 0 && canSpawn == true)
        //{
        //    CloneBeer(Pos1);
        //    CloneBeer(Pos2);
        //    CloneBeer(Pos3);
        //    CloneBeer(Pos4);
        //    CloneBeer(Pos5);
        //    canSpawn = false;
  
        //}
        //if (beerCount == 1 && canSpawn == true)
        //{
        //    CloneBeer(Pos2);
        //    canSpawn = false;
        //}
        //if (beerCount == 2 && canSpawn == true)
        //{
        //    CloneBeer(Pos3);
        //    canSpawn = false;
        //}
        //if (beerCount == 3 && canSpawn == true)
        //{
        //    CloneBeer(Pos4);
        //    canSpawn = false;
        //}
        //if (beerCount == 4 && canSpawn == true)
        //{
        //    CloneBeer(Pos5);
        //    canSpawn = false;
        //}
    //}

    //private void CloneBeer(Vector3 position)
    //{
    //    Instantiate(myPrefab[0], position, Quaternion.identity);
    }

}
