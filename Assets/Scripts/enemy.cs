using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] public float Speed = 5f;
    private GameObject Player;
    
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (Player == null)
        {
            Debug.LogError("PLAYER NOT FOUND by enemy!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
    }
}
