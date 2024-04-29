using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollider : MonoBehaviour
{
    private bool playerOneFinished = false;
    private bool playerTwoFinished = false;
    [SerializeField] private HelpText helpTextOne;
    [SerializeField] private HelpText helpTextTwo;
    [SerializeField] private GameOverMenu gameOverMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            helpTextOne.Show();
            playerOneFinished = true;
            Debug.Log("Player1 "+ playerOneFinished);
        }
        if (collision.gameObject.name == "Player2")
        {
            helpTextTwo.Show();
            playerTwoFinished = true;
            Debug.Log("Player2 "+ playerTwoFinished);

        }
        if (playerOneFinished && playerTwoFinished)
        {
            helpTextOne.Hide();
            helpTextTwo.Hide();
            gameOverMenu.Show();

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            playerOneFinished = false;
            Debug.Log("Player1 "+ playerOneFinished);

        }
        if (collision.gameObject.name == "Player2")
        {
            playerTwoFinished = false;
            Debug.Log("Player2 "+ playerTwoFinished);

        }
    }
}
