using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int _playerScore;
    private int _enemyScore;

    [SerializeField]
    private MainView _mainView;

    void Start()
    {
        _playerScore = 0;
        _enemyScore = 0;
        _mainView.UpdateScore(_playerScore, _enemyScore);
    }

    public void AddPlayerScore()
    {
        _playerScore++;
        _mainView.UpdateScore(_playerScore, _enemyScore);
    }

    public void AddEnemyScore()
    {
        _enemyScore++;
        _mainView.UpdateScore(_playerScore, _enemyScore);
    }
}
