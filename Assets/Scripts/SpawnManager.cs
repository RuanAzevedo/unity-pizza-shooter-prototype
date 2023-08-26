using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    private readonly float spawnRangeX = 20;
    private readonly float spawnPosZ = 20;
    private readonly float startDelay = 2;
    private readonly float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandonAnimal), startDelay, spawnInterval);
    }

    void SpawnRandonAnimal()
    {
        Vector3 spawnPos = new(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(
            animalPrefabs[animalIndex],
            spawnPos,
            animalPrefabs[animalIndex].transform.rotation
       );
    }
}
