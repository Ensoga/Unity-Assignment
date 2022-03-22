using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CubeSpawner))]
public class NewBehaviourScript : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CubeSpawner spawner = (CubeSpawner)target;
        if(GUILayout.Button("Create Cube"))
        {
            spawner.Spawn();
        }
    }
}
