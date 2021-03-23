using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    [SerializeField] private Camera playerCamera;
    [SerializeField] private PlayerController player;
    [SerializeField] private Transform worldStart, worldEnd;

    private float offSet;




    void Start()
    {
        playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        worldStart = GameObject.Find("WorldPosStart").GetComponent<Transform>();
        worldEnd = GameObject.Find("WorldPosEnd").GetComponent<Transform>();
        //float width = Camera.main.orthographicSize * Screen.width / Screen.height;
        playerCamera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

    }

    void Update()
    {
        CameraHandler();
    }

    private void CameraHandler()
    {
        playerCamera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);

        if (playerCamera.transform.position.x <= worldStart.position.x)
        {
            playerCamera.transform.position = new Vector3(worldStart.position.x, playerCamera.transform.position.y, playerCamera.transform.position.z);
        }
        else if (playerCamera.transform.position.x >= worldEnd.position.x)
        {
            playerCamera.transform.position = new Vector3(worldEnd.position.x, playerCamera.transform.position.y, playerCamera.transform.position.z);
        }
    }
}
