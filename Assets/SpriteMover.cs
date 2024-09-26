using Unity.VisualScripting;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 360f;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
 
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(moveX, moveY).normalized;

        transform.Translate(direction * moveSpeed * Time.deltaTime);
        if (direction.magnitude > 0)
        {
            animator.SetFloat("Speed", direction.magnitude);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
        //animator.SetFloat("Horizontal", moveX);
        //animator.SetFloat("Vertical", moveY);

        if (moveX != 0)
        {
            animator.SetFloat("Vertical", 0);
            animator.SetFloat("Horizontal", moveX);
        }
        if (moveY != 0)
        {
            animator.SetFloat("Horizontal", 0);
            animator.SetFloat("Vertical", moveY);
        }
    }
}