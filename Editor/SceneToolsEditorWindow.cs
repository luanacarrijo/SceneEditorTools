using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Mirtilo.SceneTools.Editor
{
    public static class SceneToolsEditorWindowController
    {
        [MenuItem("Mirtilo/SceneTools")]
        public static void OpenWindow()
        {
            var window = EditorWindow.GetWindow<SceneToolsEditorWindow>();
            window.Show();
        }
    }
    
    public class SceneToolsEditorWindow : EditorWindow
    {
        [Serializable]
        struct SceneInfo
        {
            public int index;
            public string asset;
            public bool enabled;
        }

        private List<SceneInfo> sceneInfo = new();
        private SerializedObject obj;
        
        private void OnEnable()
        {
            EditorBuildSettingsScene[] scenes = EditorBuildSettings.scenes;

            for (int i = 0; i < scenes.Length; i++)
            {
                sceneInfo.Add(new SceneInfo()
                {
                    index = i,
                    asset = scenes[i].path,
                    enabled = scenes[i].enabled
                });
            }

            obj = new SerializedObject(this);
        }

        private void OnGUI()
        {
            obj.Update();
            SerializedProperty prop = obj.FindProperty("_sceneInfo");
            EditorGUILayout.PropertyField(prop);
            obj.ApplyModifiedProperties();
        }

        private void OnInspectorUpdate()
        {
            Repaint();
        }
    }
}