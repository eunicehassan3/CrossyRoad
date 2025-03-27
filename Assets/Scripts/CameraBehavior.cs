
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = new Vector3(-1,3.5f,-4);
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
             gameObject.transform.position = player.transform.position + offset;
        }
       

    }
}
