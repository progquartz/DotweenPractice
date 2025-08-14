using UnityEngine;
using DG.Tweening;

public class DotweenMoving : MonoBehaviour
{
    private void Start()
    {
        TestDoMove();
        //TestDoPath();

    }

    private void TestDoPath()
    {

        var path = new Vector3[] { transform.position, new(10, 0, 0), new(10, 0, 10), new(0, 0, 10) };

        transform.DOPath(path, 2.5f, PathType.CatmullRom)
                 .SetOptions(closePath: true)     // ��
                 .SetLookAt(0.01f)                // ������� �ٶ󺸱�
                 .SetEase(Ease.InOutSine);
    }

    private void TestDoMove()
    {
        //transform.DOMove(new Vector3(3, 1, 0), 0.6f).SetEase(Ease.OutQuad);
        // �ε巯�� �̵�
        //transform.DOMove(new Vector3(5.3f, 2.7f, 0), 1f, false);

        // ���� ��ǥ ���� �̵�
        transform.DOLocalMove(new Vector3(5.3f, 2.7f, 0), 1f).SetRelative().SetEase(Ease.InBounce);

        //transform.DOMoveX(5f, 0.8f, true);
        //transform.DOLocalMove(new Vector3(0, 2, 0), 0.5f);
    }

    private void Update()
    {
        

    }
}
