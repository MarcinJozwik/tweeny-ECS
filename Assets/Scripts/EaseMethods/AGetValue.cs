using Preview;
using UnityEditor;
using UnityEngine;

namespace EaseMethods
{
    public abstract class AGetValue : MonoBehaviour
    {
        public abstract float GetValue(float time);
    }
    
    [CustomEditor(typeof(AGetValue),true)]
    public class AGetValueEditor : Editor
    {
        private AGetValue aGetValue;

        private void OnEnable()
        {
            aGetValue = target as AGetValue;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Pick", EditorStyles.miniButton))
            {
                aGetValue.GetComponent<ShapeFunction>().GetValue = aGetValue;
                aGetValue.GetComponent<ShapeFunction>().Shape();
            }
        }
    }
}