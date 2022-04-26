using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{ Start, PlayerTurn, EnemyTurn, Wait, Sell }

public class StateMachine : MonoBehaviour
{
    public GameState state;

    // Start is called before the first frame update
    private void Start()
    {
        state = GameState.Start;
    }
}