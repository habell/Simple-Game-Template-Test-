using System.Collections.Generic;
using Object = UnityEngine.Object;

namespace UI
{
    public class UIService : IUIService
    {
        private readonly Dictionary<UIView, View> _views;
        
        public UIService(UIPreset uiPreset)
        {
            _views = new Dictionary<UIView, View>();
            
            var uiRoot = Object.Instantiate(uiPreset.UIRoot);
            
            foreach (var view in uiPreset.Views)
            {
                var prefab = Object.Instantiate(view.Prefab, uiRoot.transform);
                prefab.Hide();
                _views.Add(view.UIView, prefab);
            }
        }

        public void Show(UIView view)
        {
            if (_views.ContainsKey(view))
            {
                _views[view].Show();
            }
        }

        public void Hide(UIView view)
        {
            if (_views.ContainsKey(view))
            {
                _views[view].Hide();
            }
        }
    }
}