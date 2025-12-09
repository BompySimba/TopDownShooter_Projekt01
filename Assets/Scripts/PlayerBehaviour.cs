using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager.playerHealth.DmgUnit(dmg);
        Debug.Log(GameManager.gameManager.playerHealth.Health);
    }
}
