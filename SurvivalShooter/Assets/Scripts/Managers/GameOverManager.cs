using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text warningText;
    public PlayerHealth playerHealth;

    Animator anim;

    bool isGameOver = false;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isGameOver)
        {
            if (playerHealth.currentHealth <= 0)
            {
                isGameOver = true;
                anim.SetTrigger("GameOver");
                Invoke("RestartLevel", 5);
            }
        }
    }

    public void ShowWarning(float enemyDistance)
    {
        warningText.text = string.Format("! {0} m", Mathf.RoundToInt(enemyDistance));
        anim.SetTrigger("Warning");
    }

    public void RestartLevel()
    {
        playerHealth.RestartLevel();
    }
}