using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScript : MonoBehaviour
{
    [SerializeField] private Transform followTarget;
    private float smoothTime = 0.5f;
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        
    }

    private void Update()
    {
        Vector3 targetPosition = followTarget.TransformPoint(0, 0, 0);

        transform.position = Vector3.SmoothDamp(new Vector3(followTarget.position.x + 4f , 2 ,0), targetPosition, ref velocity, smoothTime, Time.deltaTime);
    }
}
