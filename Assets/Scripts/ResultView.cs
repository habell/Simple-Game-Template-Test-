using System;
using System.Collections.Generic;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ResultView : View
    {
        [SerializeField] private Button _closeButton;
        [SerializeField] private TextMeshProUGUI _resultInfo;
        [SerializeField] private TextMeshProUGUI _timeLeft;

        private void CloseButtonClick()
        {
            Game.Instance.UIService.Show(UIView.Main);
            Game.Instance.UIService.Hide(UIView.Result);
        }
        
        public override void Show()
        {
            gameObject.SetActive(true);
            var result = Game.Instance.GameResult;
            switch (result)
            {
                case GameResult.Unknown:
                    _resultInfo.text = "Game is not started!";
                    _resultInfo.color = Color.white;
                    break;
                case GameResult.Win:
                    _resultInfo.text = "You are Win!";
                    _resultInfo.color = Color.green;
                    break;
                case GameResult.Loss:
                    _resultInfo.text = "You lose";
                    _resultInfo.color = Color.red;
                    break;
                default: 
                    break;
            }
            _timeLeft.text = Game.Instance.LastGameTime.ToString();
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            _closeButton.onClick.AddListener(CloseButtonClick);
        }

        private void OnDisable()
        {
            _closeButton.onClick.RemoveListener(CloseButtonClick);
        }
    }
}