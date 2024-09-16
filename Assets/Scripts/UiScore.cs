using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental.GraphView;
using System.Globalization;

public class UiScore : MonoBehaviour
{
    [SerializeField] private List<UiScoreItem> items = new List<UiScoreItem>();

    [SerializeField] private UiScoreItem scoreItemPrefab;

    [SerializeField] private Transform content;

    [SerializeField] TMP_InputField nameInput;
    [SerializeField] TMP_InputField scoreInput;

    [SerializeField] Button sortByKillsButton;
    [SerializeField] Button sortByAssistsButton;
    [SerializeField] Button sortByDeathsButton;
    [SerializeField] Button sortByScoreButton;

    private int maxElements = 10;

    private void Start()
    {
        for (int i = 0; i < maxElements; i++)
        {

            int Kills = Random.Range(0, 100);
            int Assists = Random.Range(0, 100);
            int Deaths = Random.Range(0, 100);

            UiScoreItem item = Instantiate(scoreItemPrefab, content);

            item.Set("Player" + i, Kills, Assists, Deaths);

            items.Add(item);

        }
    }

    private void UpdateUI()
    {
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }
    }

    void Swap(UiScoreItem x, UiScoreItem y)
    {
        string kills = x.killsText.text;
        string assists = x.assistsText.text;
        string death = x.deathsText.text;
        string score = x.scoreText.text;
        string name = x.nameText.text;

        x.killsText.text = y.killsText.text; ;
        x.assistsText.text = y.assistsText.text;
        x.deathsText.text = y.deathsText.text;
        x.scoreText.text = y.scoreText.text;

        x.nameText.text = y.nameText.text;

        y.killsText.text = kills;
        y.assistsText.text = assists;
        y.deathsText.text = death;
        y.scoreText.text = score;

        y.nameText.text = name;
    }

    public void BubbleSortKill()
    {
        int n = items.Count;

        bool finished = false;

        while (finished == false)
        {
            finished = true;

            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(items[i].killsText.text) > int.Parse(items[i + 1].killsText.text))
                {
                    Swap(items[i], items[i + 1]);

                    finished = false;
                }
            }

            n--;
        }
        
    }

    public void BubbleSortAssists()
    {
        int n = items.Count;

        bool finished = false;

        while (finished == false)
        {
            finished = true;

            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(items[i].assistsText.text) > int.Parse(items[i + 1].assistsText.text))
                {
                    Swap(items[i], items[i + 1]);

                    finished = false;
                }
            }

            n--;
        }

    }

    public void BubbleSortDeaths()
    {
        int n = items.Count;

        bool finished = false;

        while (finished == false)
        {
            finished = true;

            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(items[i].deathsText.text) > int.Parse(items[i + 1].deathsText.text))
                {
                    Swap(items[i], items[i + 1]);

                    finished = false;
                }
            }

            n--;
        }

    }

    public void BubbleSortScore()
    {
        int n = items.Count;

        bool finished = false;

        while (finished == false)
        {
            finished = true;

            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(items[i].scoreText.text) > int.Parse(items[i + 1].scoreText.text))
                {
                    Swap(items[i], items[i + 1]);

                    finished = false;
                }
            }

            n--;
        }

    }
}
