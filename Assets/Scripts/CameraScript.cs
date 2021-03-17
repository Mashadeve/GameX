using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Camera playerCamera;
    [SerializeField] private GameObject player;

    private void Start()
    {
        playerCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    private void Update()
    {
        playerCamera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
        Debug.Log("Kamera sijaitsee " + playerCamera.transform.position);
    }
}
