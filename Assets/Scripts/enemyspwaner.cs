using System.Collections;
using UnityEngine;

public class enemyspwaner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private float enemyinterval = 10f;






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnenemy(enemyinterval, enemy));
    }

    
    private IEnumerator spawnenemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(enemyinterval);
        GameObject newenenemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnenemy(interval, enemy));
    }
}
