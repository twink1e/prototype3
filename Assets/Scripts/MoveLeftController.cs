using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftController : MonoBehaviour
{
    private float speed = 8;

    private PlayerController playerController;
    private float leftBoundary = -10;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerController.gameOver) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (gameObject.CompareTag("Obstacle") && transform.position.x <= leftBoundary) {
            Destroy(gameObject);
        }
    }
}
