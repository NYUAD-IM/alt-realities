using UnityEditor;

[CustomEditor(typeof(SceneTransfer))]
public class SceneTransferEditor : Editor
{
    SerializedProperty toScene;
    SerializedProperty toLayer;
    SerializedProperty changeLayer;
    
    void OnEnable()
    {
        toScene = serializedObject.FindProperty("toScene");
        toLayer = serializedObject.FindProperty("toLayer");
        changeLayer = serializedObject.FindProperty("changeLayer");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(toScene);
        EditorGUILayout.PropertyField(changeLayer);
        if(changeLayer.boolValue)
        {
            toLayer.intValue = EditorGUILayout.LayerField("To Layer", toLayer.intValue);
        }

        serializedObject.ApplyModifiedProperties();
    }

}
