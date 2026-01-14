using UnityEngine;

public class DummyHealth : MonoBehaviour
{
    [Header("Health Settings")]
    [SerializeField] private float maxHealth = 50f;
    [SerializeField] private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        
        if(currentHealth <= 0f)
        {
            currentHealth = 0f;
            Destroy(gameObject);
            UIManager.instance.AddScore(10);
        }
    }
}
