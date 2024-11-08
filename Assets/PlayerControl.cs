using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int jumpForce = 15;

    public Vector2 moveInput;
    public Vector2 actInput;

    public Rigidbody2D rb;

    private void Update()
    {
        // Tạo control di chuyển cho nhân vật
        moveInput.x = Input.GetAxis("Horizontal");

        //Vector3 movement = new Vector3(moveInput.x, actInput.y, 0) * moveSpeed * Time.deltaTime;
        Vector3 movement = new Vector3(moveInput.x, 0) * moveSpeed * Time.deltaTime;
        transform.position += movement;

        // Xoay hướng nhân vật
        if (moveInput.x != 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = moveInput.x > 0 ? 1 : -1;
            transform.localScale = scale;
        }
        if ()
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
