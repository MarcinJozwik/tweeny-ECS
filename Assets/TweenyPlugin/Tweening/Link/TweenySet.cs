using System;
using UnityEditor;
using UnityEngine;

namespace TweenyPlugin.Tweening.Link
{
    public class TweenySet
    {
        public object value;
        public string type;

        private TweenySet()
        {
            
        }
        
        public static TweenySet OnComplete(Action action)
        {
            return new TweenySet(){type = "onComplete", value = action};
        }
        
        public static TweenySet Reverse()
        {
            return new TweenySet(){type = "onComplete"};
        }
        
        public static TweenySet SetLoops(int loops)
        {
            return new TweenySet(){type = "onComplete", value = loops};
        }
    }
}

public class TestEditor : Editor
{
    private void OnSceneGUI()
    {
        bool value = false;
        EditorGUILayout.Toggle("label", value, GUILayout.Height(100));

        GUILayoutOption option = GUILayout.Height(100);
    }
}