using UnityEngine;

public class enemy : MonoBehaviour
{
    private Transform target;
    public float Speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, Speed *Time.deltaTime);
    }
}
