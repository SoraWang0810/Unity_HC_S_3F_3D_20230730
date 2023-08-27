using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print("碰到的物件：" + hit.gameObject);
    }
}
