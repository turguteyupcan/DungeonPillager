using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (20.1f + player.position.x).ToString("0");
    }
}
