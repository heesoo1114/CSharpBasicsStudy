using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    [SerializeField] private float dragDistance = 25; // ���� �ν��� ���� �ּ� �巡�� �Ÿ�
    private Vector3 touchStart, touchEnd; // ���� ����, ���� ��ġ
    private bool isTouch = false; // �̵� or ������ ��ġ�� ������ 1ȸ�� ó���ϱ� ����

    public Direction UpdateTouch()
    {
        Direction direction = Direction.None;

        if (Input.GetMouseButtonDown(0))
        {
            isTouch = true;
            touchStart = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            if (isTouch == false) return Direction.None;

            touchEnd = Input.mousePosition;

            float deltaX = touchEnd.x - touchStart.x;
            float deltaY = touchEnd.y - touchStart.y;

            // �巡���� �Ÿ��� dragDistance ���� ������ ����
            if (Mathf.Abs(deltaX) < dragDistance && Mathf.Abs(deltaY) < dragDistance) return Direction.None;

            if (Mathf.Abs(deltaX)> Mathf.Abs(deltaY)) // Horizontal �������� �̵�
            {
                if (Mathf.Sign(deltaX) >= 0)
                {
                    direction = Direction.Right;
                }
                else
                {
                    direction = Direction.Left;
                }
            }
            else // Vertical �������� �̵�
            {
                if (Mathf.Sign(deltaY) >= 0)
                {
                    direction = Direction.Up;
                }
                else
                {
                    direction = Direction.Down;
                }
            }
        }
        
        // ��� �������ε� �̵��� �ϸ� isTouch�� false�� ����� ��ġ ����, �ٽ� ��ġ�� �ϱ� �������� ������� ����
        if (direction != Direction.None) isTouch = false;

        return direction;
    }
}
