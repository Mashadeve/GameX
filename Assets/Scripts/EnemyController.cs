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
        wolfPrefaClone[3] = Instantiate(wolfPrefab[3], start[3].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        wolfPrefaClone[4] = Instantiate(wolfPrefab[4], start[4].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        wolfPrefaClone[5] = Instantiate(wolfPrefab[5], start[5].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    private void FixedUpdate()
    {
        wolfPrefaClone[0].transform.position = new Vector2(wolfPrefaClone[0].transform.position.x - 0.1f, wolfPrefaClone[0].transform.position.y);
        wolfPrefaClone[1].transform.position = new Vector2(wolfPrefaClone[1].transform.position.x - 0.1f, wolfPrefaClone[1].transform.position.y);
        wolfPrefaClone[2].transform.position = new Vector2(wolfPrefaClone[2].transform.position.x - 0.1f, wolfPrefaClone[2].transform.position.y);
        wolfPrefaClone[3].transform.position = new Vector2(wolfPrefaClone[3].transform.position.x - 0.1f, wolfPrefaClone[3].transform.position.y);
        wolfPrefaClone[4].transform.position = new Vector2(wolfPrefaClone[4].transform.position.x - 0.1f, wolfPrefaClone[4].transform.position.y);
        wolfPrefaClone[5].transform.position = new Vector2(wolfPrefaClone[5].transform.position.x - 0.1f, wolfPrefaClone[5].transform.position.y);

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
        if (wolfPrefaClone[3].transform.position.x <= end[3].transform.position.x)
        {
            WolfDestroy(4);
        }
        if (wolfPrefaClone[4].transform.position.x <= end[4].transform.position.x)
        {
            WolfDestroy(5);
        }
        if (wolfPrefaClone[5].transform.position.x <= end[5].transform.position.x)
        {
            WolfDestroy(6);
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
        if (clone == 4)
        {
            Destroy(wolfPrefaClone[3]);
            wolfPrefaClone[3] = wolfPrefaClone[wolfPrefaClone.Length - 1];
            wolfPrefab[3] = wolfPrefab[wolfPrefab.Length - 1];
            wolfPrefaClone[3] = wolfPrefaClone[3] = Instantiate(wolfPrefab[3], start[3].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
        if (clone == 5)
        {
            Destroy(wolfPrefaClone[4]);
            wolfPrefaClone[4] = wolfPrefaClone[wolfPrefaClone.Length - 1];
            wolfPrefab[4] = wolfPrefab[wolfPrefab.Length - 1];
            wolfPrefaClone[4] = wolfPrefaClone[4] = Instantiate(wolfPrefab[4], start[4].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
        if (clone == 6)
        {
            Destroy(wolfPrefaClone[5]);
            wolfPrefaClone[5] = wolfPrefaClone[wolfPrefaClone.Length - 1];
            wolfPrefab[5] = wolfPrefab[wolfPrefab.Length - 1];
            wolfPrefaClone[5] = wolfPrefaClone[5] = Instantiate(wolfPrefab[5], start[5].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
    }
}