using System;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class MainView : View
    {
        [SerializeField]
        private Button _startButton;
        
        [SerializeField]
        private Button _resultButton;
        
        public void OnEnable()
        {
            _startButton.onClick.AddListener(StartButtonClick);
        }

        private void StartButtonClick()
        {
            Debug.Log("test");
            Game.Instance.UIService.Hide(UIView.Main);
            Game.Instance.UIService.Show(UIView.Result);
        }

        public void OnDisable()
        {
            _startButton.onClick.RemoveListener(StartButtonClick);
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