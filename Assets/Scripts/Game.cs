using System;
using System.Diagnostics;
using UI;
using UnityEngine;

namespace DefaultNamespace
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        
        [SerializeField] private Camera _camera;

        [SerializeField] private UIPreset _uiPreset;

        private LevelManager _levelManager;
        
        private Stopwatch _gameTime;

        public int LastGameTime { get; private set; }

        public Stopwatch GameTime => _gameTime;
        public LevelManager LevelManager => _levelManager;
        
        public GameObject Player => _player;

        public Camera Camera => _camera;

        public IUIService UIService { get; private set; }
        
        public GameResult GameResult { get; private set; } = GameResult.Unknown;
        
        public static Game Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
            UIService = new UIService(_uiPreset);
            UIService.Show(UIView.Main);
            _levelManager = new LevelManager();
            _gameTime = new Stopwatch();
        }

        public void GameEnding(GameResult result)
        {
            GameResult = result;
            GameTime.Stop();
            LastGameTime = GameTime.Elapsed.Seconds;
            LevelManager.UnloadScene("Game");
            UIService.Show(UIView.Result);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameTime.IsRunning)
                {
                    GameTime.Stop();
                    LevelManager.UnloadScene("Game");
                }
                UIService.Hide(UIView.Result);
                UIService.Show(UIView.Main);
            }
        }
    }
}