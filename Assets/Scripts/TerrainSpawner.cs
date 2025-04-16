using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    public int TerrainCount;
    public GameObject[] terrainPrefabs;
    private Vector3 currentPos = new Vector3(0,0,0);
    // private GameObject[] currentTerrains;
    private List<GameObject> currentTerrains;
    public float minDistanceFromPlayer;
    public GameObject player;
    private float playerPos;

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
        // if(Input.GetKeyDown(KeyCode.UpArrow)){
            SpawnTerrain();
        // }
    }

    void SpawnTerrain(){
        playerPos = player.transform.position.z;
        if(currentPos.z - playerPos < minDistanceFromPlayer){
            GameObject terrain = Instantiate(terrainPrefabs[Random.Range(0, terrainPrefabs.Length)],currentPos, Quaternion.identity );
        // currentTerrains.Append(terrain);
        currentTerrains.Add(terrain);
        if(currentTerrains.Count > TerrainCount){
            Destroy(currentTerrains[0]);
            currentTerrains.RemoveAt(0);
        }
        currentPos.z += 3; 
        }
        

    }
}
