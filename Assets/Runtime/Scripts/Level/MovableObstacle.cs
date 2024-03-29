using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObstacle : Obstacle
{
    [SerializeField] private float horizontalSpeed = 1f;
    [SerializeField] private float laneSizeX = 2f;

    private float positionTime;

    public float MovementDuration => 1f / horizontalSpeed;

    private void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        Vector3 position = transform.position;
        position.x = GetPositionX();
        transform.position = position;
    }

    private float GetPositionX()
    {
        positionTime += Time.deltaTime * horizontalSpeed;
        return (Mathf.PingPong(positionTime, 1) - 0.5f) * 2 * laneSizeX;
    }
}
