using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject BallPrefab;
    public GameObject Gun;
    public GameObject FirePos;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Gun.transform.Rotate(new Vector3(-50.0f * Time.deltaTime, 0.0f, 0.0f));
        }

        if (Input.GetKey(KeyCode.S))
        {
            Gun.transform.Rotate(new Vector3(50.0f * Time.deltaTime, 0.0f, 0.0f));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (BallPrefab)
            {
                GameObject BallObj = Instantiate(BallPrefab);

                if (BallObj)
                {
                    BallObj.transform.position = FirePos.transform.position;
                    BallObj.transform.rotation = FirePos.transform.rotation;

                    Ball ball = BallObj.GetComponent<Ball>();

                    if (ball)
                        ball.Fire(BallObj.transform.forward * 20);
                }
            }
        }
    }
}
