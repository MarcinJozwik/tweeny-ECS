using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TweenyPlugin.Core;
using TweenyPlugin.Easing.Definitions;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Unity
{
    public class HumanHeightGenerator : MonoBehaviour
    {
        public int Samples = 25;
        public float MinHeight = 1.5f;
        public float MaxHeight = 2f;
    }
    
#if UNITY_EDITOR
    [CustomEditor(typeof(HumanHeightGenerator))]
    public class HumanHeightGeneratorEditor : Editor
    {
        private HumanHeightGenerator generator;
        private List<float> numbers = new List<float>();
        private AnimationCurve curve = new AnimationCurve();
        
        private FieldInfo[] fields;
        private string[] fieldNames;
        private int index = -1;

        private void OnEnable()
        {
            generator = target as HumanHeightGenerator;
            UpdateFields();
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            index = EditorGUILayout.Popup("Ease Methods", index, fieldNames);
            
            EditorGUI.BeginDisabledGroup(index < 0);
            if (GUILayout.Button("Generate"))
            {
                Generate();
                FillCurve();
            }
            EditorGUI.EndDisabledGroup();

            if (numbers != null && numbers.Count > 0)
            {
                EditorGUILayout.CurveField(curve);//, Color.cyan, new Rect(0,0,1,1), GUILayout.MinHeight(300), GUILayout.Width(400));
            }
        }

        private void Generate()
        {
            var field = fields[index];
            Ease ease = (Ease)(field.GetValue(null));
            numbers.Clear();
            
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < generator.Samples; i++)
            {
                float value = Tweeny.Random(generator.MinHeight, generator.MaxHeight, ease);
                numbers.Add(value);
                builder.Append($"{value:F}m\n");
            }
            Debug.Log(builder.ToString());
        }

        private void FillCurve()
        {
            curve = new AnimationCurve();
            foreach (var number in numbers)
            {
                float time = number / (generator.MaxHeight - generator.MinHeight);
                curve.AddKey(time, number);
            }
        }
        
        private void UpdateFields()
        {
            fields = typeof(EaseMode).GetFields(BindingFlags.Public | BindingFlags.Static);
            fieldNames = fields.Select(f => f.Name).ToArray();
        }
    }
#endif
}