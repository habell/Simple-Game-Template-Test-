using System;
using UI;
using UnityEngine;

namespace DefaultNamespace
{
    public class Game : MonoBehaviour
    {
        [SerializeField]
        private UIPreset _uiPreset;
        
        public IUIService UIService { get; private set; }

        public static Game Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
            UIService = new UIService(_uiPreset);
            UIService.Show(UIView.Main);
        }
    }
}