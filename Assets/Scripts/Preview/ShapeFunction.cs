using System.Collections.Generic;
using EaseMethods;
using UnityEditor;
using UnityEngine;

namespace Preview
{
    public class ShapeFunction : MonoBehaviour
    {
        [HideInInspector]
        public AnimationCurve Curve;
        public AGetValue GetValue;
        public int Chunks = 100;
        public bool Normalization = true;
        [HideInInspector]
        public bool ConstantEvaluation = false;
    
        private List<KeyFrame> keyFrames = new List<KeyFrame>();

        public void Shape()
        {
            Evaluate();
            Normalize();
            Assign();
        }
    
        public void Evaluate()
        {
            keyFrames = new List<KeyFrame>();
            int count = Chunks;
            for (int i = 0; i <= count; i++)
            {
                float time = i / (float) count;
                float value = GetValue.GetValue(time);
                keyFrames.Add(new KeyFrame(time, value));
            }
        }

        public void Normalize()
        {
            if (!Normalization)
            {
                return;
            }
        
            float min = GetMinValue();
            float max = GetMaxValue();
//        float min = keyFrames[0].Value;
//        float max = keyFrames[keyFrames.Count - 1].Value;

            for (var i = 0; i < keyFrames.Count; i++)
            {
                float value = (keyFrames[i].Value - min) / max;
                keyFrames[i] = new KeyFrame(keyFrames[i].Time, value);
            }
        }

        public void Assign()
        {
            Curve = new AnimationCurve();
            foreach (var keyFrame in keyFrames)
            {
                Curve.AddKey(keyFrame.Time, keyFrame.Value);
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
    }

    [CustomEditor(typeof(ShapeFunction))]
    public class ShapeFunctionEditor : Editor
    {
        private ShapeFunction shapeFunction;

        private void OnEnable()
        {
            shapeFunction = target as ShapeFunction;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.Space();
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            EditorGUILayout.CurveField(shapeFunction.Curve, Color.cyan, new Rect(0,0,1,1), GUILayout.MinHeight(300), GUILayout.Width(400));
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            EditorGUILayout.Space();

            if (shapeFunction.ConstantEvaluation)
            {
                shapeFunction.Shape();
            }
        
            EditorGUI.BeginDisabledGroup(shapeFunction.ConstantEvaluation);
            if (GUILayout.Button("Evaluate"))
            {
                shapeFunction.Shape();
            }
            EditorGUI.EndDisabledGroup();

            shapeFunction.ConstantEvaluation = EditorGUILayout.Toggle("Constant Evaluation", shapeFunction.ConstantEvaluation);
        
            if (GUILayout.Button("Show Fullscreen"))
            {
                ShapeFunctionWindow.ShowWindow(shapeFunction);
            }
        }
    }
}