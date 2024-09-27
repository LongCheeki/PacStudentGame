using Unity.VisualScripting;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float pinX;
    public float pinY;
    public bool isDeath = false;
    public bool isScared = false;

    private Animator animator;

    private int count = 0;

    void Start()
    {
        animator = GetComponent<Animator>();

        animator.SetFloat("Speed", 5f);

        animator.SetFloat("Vertical", pinY);
        animator.SetFloat("Horizontal", pinX);
        animator.SetBool("Death", isDeath);
    }

    void Update()
    {
        if(isScared)
        {
            count++;
            if(count >= 100)
            {
                animator.SetTrigger("Scared");
                count = 0;
            }
        }
       
    }
}