using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _enemyPrefab = null;
    private GameObject enemyPrefab { get { return _enemyPrefab; } }

    public float _spawnDelay = 0.05f;

    private float spawnDelay { get { return _spawnDelay; } }

    private void Start()
    {
        InvokeRepeating("Spawn", 0, spawnDelay); // le 0 signifie que le spawn se fait au temps 0 du jeu et ensuite les ennemis spawn
                                                 // toutes les 0.5 secondes #spawnDelay
    }
    private void Spawn()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.z += Random.Range(-3.0f, 3.0f);
        Instantiate(enemyPrefab, spawnPosition, transform.rotation); // Instancier un ennemi à x position
    }
}
