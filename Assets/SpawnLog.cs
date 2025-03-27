using UnityEngine;
using System.Collections;

public class SpawnLog : MonoBehaviour
{
    public GameObject log;
    
    public GameObject spawnPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnLogs());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnLogs(){
        
        while(true){
             yield return new WaitForSeconds(Random.Range(1, 5));
            Instantiate(log, spawnPos.transform.position,log.transform.rotation);
        }

   
       
       
     
    }
}
