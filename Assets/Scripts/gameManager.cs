using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static int score;

    private TextMeshProUGUI scoreText;

    void Awake()
    {
        // Garante que só haja um gameManager
        if (FindObjectsOfType<gameManager>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void OnEnable()
    {
        // Inscreve o método no evento de carregamento de cena
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // Remove a inscrição ao descarregar o objeto
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Tenta encontrar o ScoreText na nova cena carregada
        GameObject scoreObj = GameObject.Find("ScoreText");

        if (scoreObj != null)
        {
            scoreText = scoreObj.GetComponent<TextMeshProUGUI>();
        }
    }

    void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
    }
}
