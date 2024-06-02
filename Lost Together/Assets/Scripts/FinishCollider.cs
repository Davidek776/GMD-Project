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
        }
        if (collision.gameObject.name == "Player2")
        {
            helpTextTwo.Show();
            playerTwoFinished = true;
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
            helpTextOne.Hide();
        }
        if (collision.gameObject.name == "Player2")
        {
            playerTwoFinished = false;
            helpTextTwo.Hide();
        }
    }
}
