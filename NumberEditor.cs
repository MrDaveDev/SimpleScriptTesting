using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Number))]
public class NumberEditor : Editor
{
    public override void OnInspectorGUI()
    {  
        base.OnInspectorGUI();

        Number number = (Number)target;

        if (GUILayout.Button("Generate Number"))
        {
            number.SetNumber();
        }
    }
}
