using UnityEngine;
/// <summary>
/// CameraFollowCharacterController 控制摄像机平滑地跟随角色的移动。
/// 该脚本需要挂载到摄像机上。
/// 用法：将该脚本挂载到主摄像机上，然后在 Unity 编辑器中设置脚本的 public 属性。
/// </summary>
public class CameraFollowCharacterController : MonoBehaviour
{
    /// <summary>
    /// 需要跟随的角色的 Transform 组件。
    /// 在 Unity 编辑器中设置这个属性，使其指向角色的 Transform 组件。
    /// </summary>
    public Transform playerTransform;

    /// <summary>
    /// 控制摄像机移动平滑度的参数。
    /// 值越大，摄像机跟随角色的速度越快，反之则越慢。
    /// </summary>
    public float smoothSpeed = 0.125f;

    /// <summary>
    /// 摄像机相对于角色的偏移量。
    /// 在 Unity 编辑器中设置这个属性，以控制摄像机的视角。
    /// 例如，设置为 (0, 5, 0) 会使摄像机在角色正上方5单位的位置。
    /// </summary>
    private Vector3 offset;


    private void Start()
    {
        offset = transform.position;
    }

    /// <summary>
    /// 在每一次物理更新时调用，使摄像机平滑地跟随角色。
    /// 这个方法不需要手动调用。
    /// </summary>
    void FixedUpdate()
    {
        // 计算出摄像机的目标位置
        Vector3 desiredPosition = playerTransform.position + offset;

        // 使用 Lerp 函数平滑地移动摄像机
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 更新摄像机的位置
        transform.position = smoothedPosition;
    }
}
