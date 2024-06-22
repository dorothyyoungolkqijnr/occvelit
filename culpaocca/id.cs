using UnityEditor;
using UnityEngine;

public class MyEditorWindow : EditorWindow
{
    private Vector3 globalScale;

    [MenuItem("Window/My Editor Window")]
    public static void ShowWindow()
    {
        GetWindow<MyEditorWindow>("My Editor Window");
    }

    private void OnGUI()
    {
        globalScale = EditorGUILayout.Vector3Field("Global Scale", globalScale);
    }
}
