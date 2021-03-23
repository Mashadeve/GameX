using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private PlayerController player;
    [SerializeField] private float offSet;
    [SerializeField] private Transform worldStart, worldEnd;
    private Vector3 minX, maxX;
    
       
    void Start()
    {

        playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        worldStart = GetComponent<Transform>();
        worldEnd = GetComponent<Transform>();
        //float width = Camera.main.orthographicSize * Screen.width / Screen.height;
        playerCamera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

    }

    void Update()
    {
        if (player.playerAlive)
        {
            playerCamera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offSet, -10f);
        }

        WorldPos();
        
    }

    private void WorldPos()
    {
        
        if (player.transform.position.x < worldStart.transform.position.x)
        {
            playerCamera.transform.position = new Vector3(worldStart.transform.position.x, playerCamera.transform.position.y, -10f);
        }

        if (-player.transform.position.x > -worldEnd.transform.position.x)
        {
            playerCamera.transform.position = new Vector3(worldEnd.transform.position.x, playerCamera.transform.position.y, -10f);
        }
    }

}
