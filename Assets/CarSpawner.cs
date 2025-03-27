using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public float speed;
    public GameObject spawnPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 6;
        StartCoroutine(SpawnVehicle());
    }

    // Update is called once per frame
    void Update()
    {
        
        
        

        
    }

    private IEnumerator SpawnVehicle(){
        yield return new WaitForSeconds(Random.Range(0, 3));
        GameObject car = Instantiate(carPrefabs[Random.Range(0, carPrefabs.Length)], spawnPos.transform.position,carPrefabs[0].transform.rotation );
        car.transform.Translate(Vector3.forward * speed);
    }
}
