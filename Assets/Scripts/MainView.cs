using UI;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class MainView : View
    {
        [SerializeField] private Button _startButton;
        
        [SerializeField] private Button _resultButton;
        
        private void StartButtonClick()
        {
            Game.Instance.UIService.Hide(UIView.Main);
            Game.Instance.LevelManager.LoadScene("Game");
            Game.Instance.GameTime.Start();
        }
        
        private void ResultButtonClick()
        {
            Game.Instance.UIService.Hide(UIView.Main);
            Game.Instance.UIService.Show(UIView.Result);
        }
        
        public void OnEnable()
        {
            _startButton.onClick.AddListener(StartButtonClick);
            _resultButton.onClick.AddListener(ResultButtonClick);
        }
        
        public void OnDisable()
        {
            _startButton.onClick.RemoveListener(StartButtonClick);
            _resultButton.onClick.RemoveListener(ResultButtonClick);
        }

        public override void Show()
        {
            gameObject.SetActive(true);
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }
        
    }
}