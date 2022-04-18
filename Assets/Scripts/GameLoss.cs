using DefaultNamespace;
using UI;
using UnityEngine;

public class GameLoss : MonoBehaviour
{
    [SerializeField] private float _gameLossPosition = -20f;
    private void FixedUpdate()
    {
        if (transform.position.y < _gameLossPosition)
            Game.Instance.GameEnding(GameResult.Loss);
    }
}
