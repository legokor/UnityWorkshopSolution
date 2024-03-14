using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] GameObject Obstacle;
    void Start(){
        InvokeRepeating(nameof(GenerateObstacle), 0f, 0.75f);
    }
    void GenerateObstacle(){
        Instantiate(Obstacle, transform.position, transform.rotation);
    }

}
