using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerController : MonoBehaviour
{
    [SerializeField]
    float speed = 5.5f;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movementX = new Vector2(moveX, 0);
        Vector2 movementY = new Vector2(0, moveY);

        Vector2 movement = movementX + movementY;

        transform.Translate(movement * speed * Time.deltaTime);

        if (Mathf.Abs(transform.position.x) > 7.4f)
        {
            transform.Translate(-movementX * speed * Time.deltaTime);
        }

        if (Mathf.Abs(transform.position.y) > 3.2f)
        {
            transform.Translate(-movementY * speed * Time.deltaTime);
        }

        if (moveY > 0)
        {
            animator.Play("WalkUp");
        }

        else if (moveY < 0)
        {
            animator.Play("WalkDown");
        }

        else if (moveY == 0 && moveX == 0)
        {
            animator.Play("Idle");
        }

        else if (moveX < 0)
        {
            animator.Play("WalkLeft");
        }

        else if (moveX > 0)
        {
            animator.Play("WalkRight");
        }
    }
}
