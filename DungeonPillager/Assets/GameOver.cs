using UnityEngine;

public class GameOver : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        playerMovement.enabled = false;
        other.enabled = false;
        animator.SetTrigger("Dead");
        
    }
}
