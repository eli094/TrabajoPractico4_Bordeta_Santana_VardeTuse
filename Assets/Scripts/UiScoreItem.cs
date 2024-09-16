using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class UiScoreItem : MonoBehaviour
{
    [SerializeField] public TMP_Text numberText;
    [SerializeField] public TMP_Text nameText;
    [SerializeField] public TMP_Text killsText;
    [SerializeField] public TMP_Text assistsText;
    [SerializeField] public TMP_Text deathsText;
    [SerializeField] public TMP_Text scoreText;

    [SerializeField] public int kills;
    [SerializeField] public int assists;
    [SerializeField] public int death;
    [SerializeField] public int score;

    public void Set(string name, int kills, int assists, int deaths)
    {
        nameText.text = name;

        this.kills = kills;
        this.assists = assists;
        this.death = deaths;

        killsText.text = this.kills.ToString();
        assistsText.text = this.assists.ToString();
        deathsText.text = this.death.ToString();

        scoreText.text = (kills * 3+ assists * 1 - deaths * 1).ToString();

        if (int.Parse(scoreText.text) < 0)
        {
            scoreText.text = 0.ToString();  
        }
    }
}
