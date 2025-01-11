using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnCooldown = 2f;

    private float timeSinceLastSpawn = 0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && timeSinceLastSpawn >= spawnCooldown)
        {

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            timeSinceLastSpawn = 0f;
        }
    }
}
