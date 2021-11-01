using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SceneTransfer))]
public class SceneTransferEditor : Editor
{
    SerializedProperty toScene;
    SerializedProperty changeLayer;
    SerializedProperty toLayer;

    void OnEnable()
    {
        toScene = serializedObject.FindProperty("toScene");
        changeLayer = serializedObject.FindProperty("changeLayer");
        toLayer = serializedObject.FindProperty("toLayer");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(toScene);
        EditorGUILayout.PropertyField(changeLayer);

        if(changeLayer.boolValue)
        {
            int curLayer = toLayer.intValue;
            toLayer.intValue = EditorGUILayout.LayerField("To Layer", curLayer);
        }

        serializedObject.ApplyModifiedProperties();
    }

}
