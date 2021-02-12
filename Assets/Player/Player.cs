using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject BallPrefab;
    public GameObject Gun;
    public GameObject FirePos;
    public int BallCount = 0;
    public int Score = 0;
    public Text CountText;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        CountText.text = "0";
        ScoreText.text = "Score : 0";
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

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0.0f, -50.0f * Time.deltaTime, 0.0f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0.0f, 50.0f * Time.deltaTime, 0.0f));
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
                    {
                        ball.Fire(BallObj.transform.forward * 20);
                        ball.m_Player = this;
                    }
                }

                ++BallCount;

                CountText.text = BallCount.ToString();
            }
        }
    }

    public void AddScore()
    {
        ++Score;

        ScoreText.text = "Score : ";
        ScoreText.text += Score.ToString();
    }
}
