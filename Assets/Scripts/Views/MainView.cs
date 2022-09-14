using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    [SerializeField]
    private Text _score;

    public void UpdateScore(int player, int enemy)
    {
        _score.text = $"{player}:{enemy}";
    }
}
