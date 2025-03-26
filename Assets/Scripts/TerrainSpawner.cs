using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    public int TerrainCount;
    public GameObject[] terrainPrefabs;
    private Vector3 currentPos = new Vector3(0,0,0);
    // private GameObject[] currentTerrains;
    private List<GameObject> currentTerrains;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTerrains = new List<GameObject>();
       for(int i= 0; i < TerrainCount; i++){
        SpawnTerrain();
       }
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            SpawnTerrain();
        }
    }

    void SpawnTerrain(){
        
        GameObject terrain = Instantiate(terrainPrefabs[Random.Range(0, terrainPrefabs.Length)],currentPos, Quaternion.identity );
        // currentTerrains.Append(terrain);
        currentTerrains.Add(terrain);
        if(currentTerrains.Count > TerrainCount){
            Destroy(currentTerrains[0]);
            currentTerrains.RemoveAt(0);
        }
        currentPos.z += 2; 

    }
}
