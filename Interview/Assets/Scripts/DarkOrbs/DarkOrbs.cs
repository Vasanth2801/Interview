using UnityEngine;
using UnityEngine.SceneManagement;

public class DarkOrbs : MonoBehaviour
{
    public GameObject instructionPanel;
    [SerializeField] bool playerIsClose = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerIsClose = true;
            instructionPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerIsClose = true;
            instructionPanel.SetActive(false);
        }
    }

    private void Update()
    {
        if(playerIsClose && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(1);
        }
    }
}
