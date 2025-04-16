
using UnityEngine;



public class PlayerBehavior : MonoBehaviour
{
    public static int score; 
    private Animator animator;
    public GameObject gameOverPanel;
    private bool isGrounded = true;
    bool isHopping = false;
    bool isDead = false;
    private AudioSource crashAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        animator = GetComponent<Animator>();
        transform.position = new Vector3(0,.5f,0);
        crashAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && !isHopping && !isDead){
            
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

         animator.SetTrigger("hopTrigger");
        // isGrounded = false;
        // animator.SetBool("hop", true);
        isHopping = true;
        // rb.linearVelocity = new Vector3(0, 5f, 0);
        gameObject.transform.position += new Vector3(0,0,.7f);
        
        // rb.linearVelocity = new Vector3(0, 5f, 0);
        score += 5;
    }

    // public void FinishHop(){
    //     animator.SetBool("hop", false);
    //     isHopping = false;
    // }

    // private void OnLanding()
    // {
    //     isGrounded = true;
    //     animator.SetBool("hop", false);
    // }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle"){
            gameOverPanel.SetActive(true);
            isDead = true;

            // gameObject.transform.position = gameObject.transform.position;
           
           crashAudio.Play();
            Debug.Log("Game Over");
        }

        if (collision.gameObject.CompareTag("terrain")) 
        {
            ResetToIdle();
            // animator.ResetTrigger("hop"); // Reset trigger
            // animator.Play("Idle");
        }


    }

    public void ResetToIdle()
    {
        animator.ResetTrigger("hop");
        // animator.Play("Idle");
        isHopping = false;
    }
}
