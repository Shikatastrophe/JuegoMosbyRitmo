using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public AudioSource hitSFX;
    public AudioSource missSFX;
    public TextMeshProUGUI scoreText;
    static int comboScore;
    static int score = 0;
    public static int scoreholder;
    public TextMeshProUGUI scoreText2;
    void Start()
    {
        Instance = this;
        comboScore = 0;
        score = 0;
        scoreholder = 0;
        scoreText.text = score.ToString();
        scoreText2.text = "0";
    }
    public static void Hit()
    {
        comboScore += 1;
        scoreholder += 6;
        Instance.hitSFX.Play();
    }
    public static void Miss()
    {
        comboScore = 0;
        Instance.missSFX.Play();    
    }
    private void Update()
    {
        scoreText.text = scoreholder.ToString();
        scoreText2.text = comboScore.ToString();
    }
}
