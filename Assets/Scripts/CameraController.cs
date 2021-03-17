using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera playerCamera;
    [SerializeField] private GameObject player;
    [SerializeField] private float offSet;

    void Start()
    {
        playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();        
    }

    void Update()
    {
        playerCamera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offSet, -15f);
        
    }
}
