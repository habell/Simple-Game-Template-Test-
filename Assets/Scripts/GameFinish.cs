using System;
using DefaultNamespace;
using UI;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class GameFinish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            Game.Instance.GameEnding(GameResult.Win);
    }
}
