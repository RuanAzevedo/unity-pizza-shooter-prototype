using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private readonly float topBound = 30;
    private readonly float lowerBound = -10;

    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
