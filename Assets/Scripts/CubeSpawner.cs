using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public List<GameObject> cubes = new List<GameObject>();
    public Vector3 SpawnPosition;
    public bool isRandomized;

    public void Spawn()
    {
        int index = isRandomized ? Random.Range(0, cubes.Count) : 0;
        if(cubes.Count>0)
        {
            Instantiate(cubes[index], SpawnPosition, Quaternion.identity);
        }
    }
}
