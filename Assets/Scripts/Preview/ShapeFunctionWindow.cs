using UnityEditor;
using UnityEngine;

namespace Preview
{
    public class ShapeFunctionWindow : EditorWindow
    {
        private ShapeFunction shapeFunction;

        public static void ShowWindow(ShapeFunction shapeFunction)
        {
            var window = GetWindow<ShapeFunctionWindow>(typeof(SceneView));
            window.titleContent = new GUIContent("Shape Preview");
            window.shapeFunction = shapeFunction;
            window.Show();
        }
        
        private void OnGUI()
        {
            if (shapeFunction != null)
            {
                var editor = Editor.CreateEditor(shapeFunction);
                editor.OnInspectorGUI();
            }
        }
        
        public void Update()
        {
            // This is necessary to make the framerate normal for the editor window.
            Repaint();
        }
    }
}