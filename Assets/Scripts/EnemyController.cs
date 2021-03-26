using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject wolf;

    private float moveSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            wolf.transform.position = new Vector2(wolf.transform.position.x * moveSpeed, wolf.transform.position.y);
        }
    }
}
