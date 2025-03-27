using UnityEngine;

public class VehicleBehavior : MonoBehaviour
{
    private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 6;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OllisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player"){
            Destroy(collision.gameObject);
        }
    }
}
