using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float xRange = 20;

    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    void MovePlayer()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
    }
}
