using UnityEngine;

public class Player : MonoBehaviour
{
    public Enemy enemy;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name.Contains("瓶子"))
        {
            enemy.enabled = true;
        }

        if (hit.gameObject.name.Contains("MND"))
        {
            print("失敗!!");
        }
    }
}
