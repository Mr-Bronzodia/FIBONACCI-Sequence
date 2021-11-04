using UnityEngine;

public class SpawnRock : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject prefabToSpawn;

    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            Instantiate(prefabToSpawn, spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
