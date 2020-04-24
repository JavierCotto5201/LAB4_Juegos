using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float score = 0;
    public Text scoreText;
    void Start()
    {

        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray MyRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(MyRay, out hitInfo))
            {
                BoxCollider bc = hitInfo.collider as BoxCollider;

                if (bc != null) 
                {
                    Destroy(bc.gameObject);
                    score++;
                }

            }

            if (scoreText)
                scoreText.text = "Score: " + score.ToString();
        }
    }
}
