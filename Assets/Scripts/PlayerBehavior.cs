
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0,0.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Hop();
        }
    
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
          gameObject.transform.position += new Vector3(-.5f,0,0);
        }
         if(Input.GetKeyDown(KeyCode.RightArrow)){
          gameObject.transform.position += new Vector3(.5f,0,0);
        }
    
    }
    void Hop(){
        
        gameObject.transform.position += new Vector3(0,0,.5f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle"){
            Debug.Log("Game Over");
        }
    }
}
