using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class DeleteTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gameObject.transform.position.y <= -7
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
    if(other.gameObject.CompareTag("Obstacle")){
        Destroy(other.gameObject);
    }
     }
}
