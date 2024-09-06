using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 80.0f; // 旋轉速度變量

    void Update()
    {
        // 讓物體在 Y 軸上旋轉
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }
}
