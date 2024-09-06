using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 設置角色移動速度
    public float speed = 10.0f;

    void Update()
    {
        // 取得玩家輸入
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // 基於輸入方向創建一個移動向量
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // 將角色移動
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
