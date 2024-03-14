using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] GameObject msg;
    [SerializeField] Rigidbody rb;
    int score;
    void Start()
    {
        score = 0;
    }
    public void IncreaseScore(){
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector3.up * 4f, ForceMode.VelocityChange);
        }
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Obstacle"){
            Time.timeScale = 0;
            int highScore = PlayerPrefs.GetInt("rekord");
            txt.text = score + ", HighScore: " + highScore;
            msg.SetActive(true);
            if (score > highScore){
                PlayerPrefs.SetInt("rekord", score);
                PlayerPrefs.Save();
            }
        }
    }
}
