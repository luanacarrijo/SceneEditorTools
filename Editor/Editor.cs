using UnityEngine;
using UnityEditor;

namespace Mirtilo.Template.Editor
{

    public class TemplateEditor : EditorWindow
    {
        [MenuItem("Window/Template")]
        public static void Open()
        {
            EditorWindow.GetWindow<TemplateEditor>();
        }
    }
}