using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverTrigger : MonoBehaviour
{
    public Text gameOverText;
    private bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText").GetComponent<Text>();
        gameOverText.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GameOverTrigger") && !gameOver)
        {
            gameOver = true;
            gameOverText.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
