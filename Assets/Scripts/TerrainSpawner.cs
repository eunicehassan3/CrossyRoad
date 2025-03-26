using System.Runtime.CompilerServices;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    public GameObject[] terrainPrefabs;
    private Vector3 currentPos = new Vector3(0,0,0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
       SpawnTerrain();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            SpawnTerrain();
        }
    }

    void SpawnTerrain(){
        
        Instantiate(terrainPrefabs[Random.Range(0, terrainPrefabs.Length)],currentPos, Quaternion.identity );
        currentPos.z += 2; 

    }
}
