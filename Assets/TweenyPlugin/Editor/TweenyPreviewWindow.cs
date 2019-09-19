using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TweenyPlugin.Easing.Definitions;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR;

namespace TweenyPlugin.Editor
{
    public class TweenyPreviewWindow : EditorWindow
    {
        #region Fields

        private int samples = 100;
        private bool normalization = true;
        
        private AnimationCurve curve;
        private Ease ease;
        private List<KeyFrame> keyFrames = new List<KeyFrame>();
        
        private FieldInfo[] fields;
        private string[] fieldNames;
        private int index = -1;

        #endregion

        #region GUI

        [MenuItem(itemName: "Tweeny Preview", menuItem = "Tools/Tweeny/Tweeny Preview")]
        public static void ShowWindow()
        {
            var window = GetWindow<TweenyPreviewWindow>(typeof(SceneView));
            window.titleContent = new GUIContent("Tweeny Preview");
            window.Show();
        }

        private void OnEnable()
        {
            UpdateFields();
        }

        private void OnGUI()
        {
            HandleInput();
            
            EditorGUI.BeginChangeCheck();
            
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Settings", EditorStyles.boldLabel);
            samples = EditorGUILayout.IntField("Samples", samples);
            normalization = EditorGUILayout.Toggle("Normalization", normalization);
            EditorGUILayout.Space();
            
            EditorGUILayout.LabelField("Preview", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            EditorGUILayout.CurveField(curve, Color.cyan, new Rect(0,0,1,1), GUILayout.MinHeight(300), GUILayout.Width(400));
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            EditorGUILayout.Space();

            index = EditorGUILayout.Popup("Ease Methods", index, fieldNames);
            
            if (EditorGUI.EndChangeCheck())
            {
                if (index >= 0)
                {
                    Preview();
                }
            }
        }
        
        #endregion

        #region Utilities

        private void HandleInput()
        {
            Event e = Event.current;
            if (e.type == EventType.KeyDown)
            {
                if (e.keyCode == KeyCode.DownArrow)
                {
                    if (index + 1 < fields.Length)
                    {
                        index++;
                        Preview();
                        Repaint();
                    }
                }

                if (e.keyCode == KeyCode.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        Preview();
                        Repaint();
                    }
                }
            }
        }
        private void Preview()
        {
            var field = fields[index];
            Ease ease = (Ease)(field.GetValue(null));
            this.ease = ease;
            Shape();
        }

        private void UpdateFields()
        {
            fields = typeof(EaseMode).GetFields(BindingFlags.Public | BindingFlags.Static);
            fieldNames = fields.Select(f => f.Name).ToArray();
        }

        #endregion

        #region Evaluation

        public void Shape()
        {
            Evaluate();
            Normalize();
            Assign();
        }
    
        public void Evaluate()
        {
            keyFrames = new List<KeyFrame>();
            int count = samples;
            for (int i = 0; i <= count; i++)
            {
                float time = i / (float) count;
                float value = ease.Get(time);
                keyFrames.Add(new KeyFrame(time, value));
            }
        }

        public void Normalize()
        {
            if (!normalization)
            {
                return;
            }
        
            float min = GetMinValue();
            float max = GetMaxValue();
            
            for (var i = 0; i < keyFrames.Count; i++)
            {
                float value = (keyFrames[i].Value - min) / max;
                keyFrames[i] = new KeyFrame(keyFrames[i].Time, value);
            }
        }

        public void Assign()
        {
            curve = new AnimationCurve();
            foreach (var keyFrame in keyFrames)
            {
                curve.AddKey(keyFrame.Time, keyFrame.Value);
            }
        }

        private float GetMinValue()
        {
            float min = 1f;
            foreach (var keyFrame in keyFrames)
            {
                if (keyFrame.Value < min)
                {
                    min = keyFrame.Value;
                }
            }
            return min;
        }
    
        private float GetMaxValue()
        {
            float max = 0f;
            foreach (var keyFrame in keyFrames)
            {
                if (keyFrame.Value > max)
                {
                    max = keyFrame.Value;
                }
            }
            return max;
        }

        #endregion
    }
}