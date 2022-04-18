using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    [CreateAssetMenu(fileName = "UIPreset", menuName = "Example/UIPreset", order = 0)]
    public class UIPreset : ScriptableObject
    {
        [SerializeField] private Canvas _uiRoot;

        [SerializeField] private List<ViewData> _views;

        public Canvas UIRoot => _uiRoot;
        public List<ViewData> Views => _views;
    }
}