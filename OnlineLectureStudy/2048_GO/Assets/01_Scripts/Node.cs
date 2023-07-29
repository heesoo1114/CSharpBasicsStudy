using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    None = -1,
    Right = 0,
    Down, 
    Left,
    Up,
}

public class Node : MonoBehaviour
{
    public Block placedBlock; // ���� ��忡 ��ġ�Ǿ� �ִ� ��� ���� (������ null)
    public Vector2 localPosition; // ���� ����� RextTransform ���� ��ǥ

    public bool Combined = false; // ���� ��忡 �ִ� ����� ���������� üũ

    public Vector2Int Point { private set; get; } // ���� ����� x, y ���� ��ǥ ���� (�»���� 0, 0)
    public Vector2Int?[] NeighborNodes { private set; get; } // ���� ��忡 ������ ����� ���� ��ǥ (������ null)

    private Board board;

    public void Setup(Board board, Vector2Int?[] neighborNodes, Vector2Int point)
    {
        this.board = board;
        NeighborNodes = neighborNodes;
        Point = point;
    }

    public Node FindTarget(Node originalNode, Direction direction, Node farNode = null)
    {
        if (NeighborNodes[(int)direction].HasValue == true)
        {
            // direction ���⿡ �ִ� ���� ��� ����
            Vector2Int point = NeighborNodes[(int)direction].Value;
            Node neighborNode = board.NodeList[point.y * board.BlockCount.x + point.x];

            // ���� ��尡 ���� �����̸� this ��ȯ
            if (neighborNode != null && neighborNode.Combined)
            {
                return this;
            }

            // �� ��� ��� ����� ��ġ�Ǿ� �ְ�
            if (neighborNode.placedBlock != null && originalNode.placedBlock != null)
            {
                // �� ��忡 �ִ� ����� ���ڰ� ������
                if (neighborNode.placedBlock.Numeric == originalNode.placedBlock.Numeric)
                {
                    return neighborNode;
                }
                else
                {
                    return farNode;
                }
            }

            // ������忡 ����� ������ ����Լ� ȣ�� (���� ĭ �̵��� ����)
            return neighborNode.FindTarget(originalNode, direction, neighborNode);
        }

        return farNode;
    }
}
