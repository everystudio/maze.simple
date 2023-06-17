using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MyComponent))]
public class MyComponentEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MyComponent myComponent = (MyComponent)target;
        if (GUILayout.Button("My Button"))
        {
            myComponent.PerformAction();
        }
    }
}
