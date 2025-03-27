
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerBehavior : MonoBehaviour
{
    public static int score; 
    private Animator animator;
    public GameObject gameOverPanel;
    bool isHopping = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        animator = GetComponent<Animator>();
        transform.position = new Vector3(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && isHopping){
            
            Hop();
            isHopping = true;
        }
    
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
          gameObject.transform.position += new Vector3(-.5f,0,0);
        }
         if(Input.GetKeyDown(KeyCode.RightArrow)){
          gameObject.transform.position += new Vector3(.5f,0,0);
        }
    
    }
    void Hop(){
        
        // animator.SetTrigger("hop");
        gameObject.transform.position += new Vector3(0,0,.5f);
        score += 5;
    }

    public void FinishHop(){
        isHopping = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle"){
            gameOverPanel.SetActive(true);
            isHopping = false;
            // gameObject.transform.position = gameObject.transform.position;
            // SceneManager.LoadScene("GameOver");
            Debug.Log("Game Over");
        }
    }
}
