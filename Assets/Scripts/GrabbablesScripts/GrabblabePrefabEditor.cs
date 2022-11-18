using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GrabbablePrefabCreator))]
public class GrabblabePrefabEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Create OVR Grabbable Template");
        DrawDefaultInspector();

        GrabbablePrefabCreator grabTemplate = (GrabbablePrefabCreator)target;

        if (GUILayout.Button("Create template free transform"))
        {
            grabTemplate.CreateObjectFreeTransform();
        }
        if (GUILayout.Button("Create template rotate transform"))
        {
            grabTemplate.CreateObjectRotate();
        }
        if (GUILayout.Button("Create Item from SO"))
        {
            if (grabTemplate.item != null)
            { 
                InstantiateSO(grabTemplate.item);
            }
            else
            {
                Debug.LogError("Item is empty");
            }
           
        }
    }

    private void InstantiateSO(GrabbableSO item)
    {
        item = (GrabbableSO)ScriptableObject.CreateInstance(typeof(GrabbableSO));

        
    }
}