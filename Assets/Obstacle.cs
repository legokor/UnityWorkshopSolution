using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0, Random.Range(-1.5f, 2f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * -1 * speed * Time.deltaTime);
        if (transform.position.z <= -10) Destroy(gameObject);
    }
    private void OnTriggerExit(Collider other) {
        other.GetComponent<BirdController>().IncreaseScore();
    }
}
