using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
public class MoveSquare : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 5f;
    private Vector2 startPosition;
    private float currentDistance = 0f;
    private bool isMovingUp = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Move vertically
        currentDistance += speed * Time.deltaTime;
        if (currentDistance >= distance)
        {
            isMovingUp = !isMovingUp;
            currentDistance = 0f;
        }

        float verticalMovement = isMovingUp ? 1f : -1f;
        transform.Translate(new Vector2(0f, verticalMovement) * speed * Time.deltaTime);
    }
}*/

public class Move_Auto : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 5f;
    private Vector3 startPosition;
    private float currentDistance = 0f;
    private bool isMovingLeft = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Move horizontally
        currentDistance += speed * Time.deltaTime;
        if (currentDistance >= distance)
        {
            isMovingLeft = !isMovingLeft;
            currentDistance = 0f;
        }

        float horizontalMovement = isMovingLeft ? -1f : 1f;
        Vector3 direction = new Vector3(0f, 0f,horizontalMovement );
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
