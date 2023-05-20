using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    //public Animator animator;

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        if (movement.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            Animator animator = GetComponent<Animator>();
            animator.SetBool("isWalking", true);
        }
        else
        {
            Animator animator = GetComponent<Animator>();
            animator.SetBool("isWalking", false);
        }

        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}