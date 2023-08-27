using UnityEngine;

public class Player : MonoBehaviour
{
    public Enemy enemy;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //print($"碰到的物件：{hit.gameObject}");
        if (hit.gameObject.name.Contains("瓶子"))
        {
            enemy.enabled = true;
        }

        if (hit.gameObject.name.Contains("MND"))
        {
            print("<color=#6699FF>遊戲失敗!!!</color>");
        }
        
    }
}
