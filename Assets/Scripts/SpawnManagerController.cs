using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerController : MonoBehaviour
{

    public GameObject prefab;

    private Vector3 spawnPos = new Vector3(20, 0, 0);

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 2);
        playerController = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn() {
        if (!playerController.gameOver) {
            Instantiate(prefab, spawnPos, prefab.transform.rotation);
        }
    }
}
