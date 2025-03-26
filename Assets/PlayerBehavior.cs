
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Hop();
        }
    
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
          gameObject.transform.position += new Vector3(0,-.5f,0);
        }
         if(Input.GetKeyDown(KeyCode.RightArrow)){
          gameObject.transform.position += new Vector3(0,.5f,0);
        }
    
    }
    void Hop(){
        
        gameObject.transform.position += new Vector3(0,0,2f);
    }
}
