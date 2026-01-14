using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryOrb : MonoBehaviour
{
    [SerializeField] GameObject instructionPanel;
    [SerializeField] bool playerIsClose = false;
    [SerializeField] GameObject winScreen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsClose = true;
            instructionPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerIsClose = true;
            instructionPanel.SetActive(false);
        }
    }

    private void Update()
    {
        if (playerIsClose && Input.GetKeyDown(KeyCode.E))
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
