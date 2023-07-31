using UnityEngine;
/// <summary>
/// CameraFollowCharacterController ���������ƽ���ظ����ɫ���ƶ���
/// �ýű���Ҫ���ص�������ϡ�
/// �÷������ýű����ص���������ϣ�Ȼ���� Unity �༭�������ýű��� public ���ԡ�
/// </summary>
public class CameraFollowCharacterController : MonoBehaviour
{
    /// <summary>
    /// ��Ҫ����Ľ�ɫ�� Transform �����
    /// �� Unity �༭��������������ԣ�ʹ��ָ���ɫ�� Transform �����
    /// </summary>
    public Transform playerTransform;

    /// <summary>
    /// ����������ƶ�ƽ���ȵĲ�����
    /// ֵԽ������������ɫ���ٶ�Խ�죬��֮��Խ����
    /// </summary>
    public float smoothSpeed = 0.125f;

    /// <summary>
    /// ���������ڽ�ɫ��ƫ������
    /// �� Unity �༭��������������ԣ��Կ�����������ӽǡ�
    /// ���磬����Ϊ (0, 5, 0) ��ʹ������ڽ�ɫ���Ϸ�5��λ��λ�á�
    /// </summary>
    private Vector3 offset;


    private void Start()
    {
        offset = transform.position;
    }

    /// <summary>
    /// ��ÿһ���������ʱ���ã�ʹ�����ƽ���ظ����ɫ��
    /// �����������Ҫ�ֶ����á�
    /// </summary>
    void FixedUpdate()
    {
        // ������������Ŀ��λ��
        Vector3 desiredPosition = playerTransform.position + offset;

        // ʹ�� Lerp ����ƽ�����ƶ������
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // �����������λ��
        transform.position = smoothedPosition;
    }
}
