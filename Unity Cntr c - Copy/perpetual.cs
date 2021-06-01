
using UnityEngine;

public class obstacle : MonoBehaviour
{

    public float forwardForce = 2000f;
    private Rigidbody rb;
    public Vector3 killZone;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void ixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(transform.position.x < killZone.x)
        {
            Destroy(this.gameObject);
        }
    }
}
