using UnityEngine;

public class GameOver : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Animator animator;
    public Transform tile;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "TileMove")
        {
            SoundManagerScript.PlaySound("death");
            playerMovement.enabled = false;
            other.enabled = false;
            animator.SetTrigger("Dead");
        }
        else
        {
            tile.position = other.transform.position + new Vector3(23.8f, 0, 0);
            //tile[Random.Range(0, tile.Length)].position = other.transform.position + new Vector3(23.8f, 0, 0);
            other.transform.position += new Vector3(11.9f, 0, 0);
        }
        
        
    }
}
