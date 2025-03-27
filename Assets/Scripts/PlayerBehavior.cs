
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerBehavior : MonoBehaviour
{
    public static int score; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
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
        score += 5;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle"){
            // SceneManager.LoadScene("GameOver");
            Debug.Log("Game Over");
        }
    }
}
