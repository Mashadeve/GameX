﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject wolf;
    [SerializeField] private Transform start,end;


    private void Start()
    {
        wolf.transform.position = GameObject.Find("Wolf_1").GetComponent<Transform>().position;
        wolf.transform.position = new Vector2(start.position.x, start.position.y - 1.5f);
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        wolf.transform.position = new Vector2(wolf.transform.position.x - 0.1f, wolf.transform.position.y);
    }

}
