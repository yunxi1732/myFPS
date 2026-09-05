using UnityEngine;
[RequireComponent(typeof(Animator))]
public class DoorAnimation : MonoBehaviour
{
    private Animator animator;

    // true = 门应该打开
    // false = 门应该关闭
    private bool shouldOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shouldOpen = true;
            animator.SetBool("Trigger", shouldOpen);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shouldOpen = false;
            animator.SetBool("Trigger", shouldOpen);
        }
    }
}


