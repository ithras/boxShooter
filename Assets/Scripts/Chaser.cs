using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    private Transform playerTransform;
    public float speed = 4f;
    public float minDist = 2f;

    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
            playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform == null)
            return;

        transform.LookAt(playerTransform.position);

        float distance = Vector3.Distance(transform.position, playerTransform.position);

        if (distance > minDist)
            transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void SetPlayer(Transform newTransform)
    {
        playerTransform = newTransform;
    }
}
