using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public GameObject spawnPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        StartCoroutine(SpawnVehicle());
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private IEnumerator SpawnVehicle(){
        
        while(true){
             yield return new WaitForSeconds(Random.Range(1, 3));
            Instantiate(carPrefabs[Random.Range(0, carPrefabs.Length)], spawnPos.transform.position,carPrefabs[0].transform.rotation );
        }

   
       
       
     
    }
}
