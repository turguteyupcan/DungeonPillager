using UnityEngine;

public class GameOver : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Animator animator;

    [SerializeField] private Transform prefab1, prefab2, prefab3, prefab4, prefab5, rastgeleengel1;
    [SerializeField] private Transform sceneMaker;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SceneMaker"))
        {
            
            rastgeleengelolustur();
            
            
        }
        else if (other.CompareTag("ScenePositionChanger"))
        {
            sceneMaker.position = new Vector3(rastgeleengel1.position.x + 47.71f, 0, 0);
            //Debug.Log("rastgeleengelPosX: " + rastgeleengel1.position.x);
        }
        else
        {
            SoundManagerScript.PlaySound("death");
            playerMovement.enabled = false;
            other.enabled = false;
            animator.SetTrigger("Dead");
        }

    }
    int onceki = -1;
    void rastgeleengelolustur()
    {
        int engelrastgele = Random.Range(0, 4);
        
        while (engelrastgele==onceki)
        {
            engelrastgele = Random.Range(0, 4);
        }
        onceki = engelrastgele;
        Debug.Log(engelrastgele);
        switch (engelrastgele)
        {
            case 0:
                rastgeleengel1 = prefab1;
                break;
            case 1:
                rastgeleengel1 = prefab2;
                break;
            case 2:
                rastgeleengel1 = prefab3;
                break;
            case 3:
                rastgeleengel1 = prefab4;
                break;
            case 4:
                rastgeleengel1 = prefab5;
                break;

        }
        rastgeleengel1.position = new Vector3(sceneMaker.position.x + 23.75f, 0, 0);
        
    }

}
