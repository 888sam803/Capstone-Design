using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Go();
    }

    private void Go()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
