using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private PlayerController controller;

    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<PlayerController>();
    }

    void Update()
    {
        animator.SetFloat("Speed", controller.GetSpeed());
        animator.SetBool("IsRunning", controller.IsRunning());
        animator.SetBool("IsJumping", !controller.IsGrounded());
    }
}
