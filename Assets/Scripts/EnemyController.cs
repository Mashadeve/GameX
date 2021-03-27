using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject[] wolfPrefab;
    [SerializeField] private GameObject[] wolfPrefaClone;
    [SerializeField] private Transform[] start, end;

    private void Start()
    {
        WolfSpawn();
    }

    private void WolfSpawn()
    {
        wolfPrefaClone[0] = Instantiate(wolfPrefab[0], start[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        wolfPrefaClone[1] = Instantiate(wolfPrefab[1], start[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        wolfPrefaClone[2] = Instantiate(wolfPrefab[2], start[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    private void FixedUpdate()
    {
        wolfPrefaClone[0].transform.position = new Vector2(wolfPrefaClone[0].transform.position.x - 0.1f, wolfPrefaClone[0].transform.position.y);
        wolfPrefaClone[1].transform.position = new Vector2(wolfPrefaClone[1].transform.position.x - 0.1f, wolfPrefaClone[1].transform.position.y);
        wolfPrefaClone[2].transform.position = new Vector2(wolfPrefaClone[2].transform.position.x - 0.1f, wolfPrefaClone[2].transform.position.y);

        if (wolfPrefaClone[0].transform.position.x <= end[0].transform.position.x)
        {
            WolfDestroy(1);
        }
        if (wolfPrefaClone[1].transform.position.x <= end[1].transform.position.x)
        {
            WolfDestroy(2);
        }
        if (wolfPrefaClone[2].transform.position.x <= end[2].transform.position.x)
        {
            WolfDestroy(3);
        }
    }

    private void WolfDestroy(int clone)
    {
        if (clone == 1)
        {
            Destroy(wolfPrefaClone[0]);
            wolfPrefaClone[0] = wolfPrefaClone[wolfPrefaClone.Length - 1];
            wolfPrefab[0] = wolfPrefab[wolfPrefab.Length - 1];
            wolfPrefaClone[0] = wolfPrefaClone[0] = Instantiate(wolfPrefab[0], start[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
        if (clone == 2)
        {
            Destroy(wolfPrefaClone[1]);
            wolfPrefaClone[1] = wolfPrefaClone[wolfPrefaClone.Length - 1];
            wolfPrefab[1] = wolfPrefab[wolfPrefab.Length - 1];
            wolfPrefaClone[1] = wolfPrefaClone[1] = Instantiate(wolfPrefab[1], start[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
        if (clone == 3)
        {
            Destroy(wolfPrefaClone[2]);
            wolfPrefaClone[2] = wolfPrefaClone[wolfPrefaClone.Length - 1];
            wolfPrefab[2] = wolfPrefab[wolfPrefab.Length - 1];
            wolfPrefaClone[2] = wolfPrefaClone[2] = Instantiate(wolfPrefab[2], start[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
    }
}