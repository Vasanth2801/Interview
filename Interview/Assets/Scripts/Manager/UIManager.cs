using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score;


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        scoreText.text = "Score: " + score.ToString(); 
    }

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;
    }
}