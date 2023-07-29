using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject nonPrefab; // ��� ��� ���� ������
    [SerializeField] private RectTransform nodeRect; // ������ ������ �θ� RectTransform

    public List<Node> SpawnNodes(Board board ,Vector2Int blockCount)
    {
        List<Node> nodeList = new List<Node>(blockCount.x * blockCount.y);

        for (int y = 0; y < blockCount.y; y++)
        {
            for (int x = 0; x < blockCount.x; x++)
            {
                GameObject clone = Instantiate(nonPrefab, nodeRect.transform);

                // ���� ����� x, y ���� ��ǥ ����
                Vector2Int point = new Vector2Int(x, y);

                // ���� ��� ���� ����
                Vector2Int?[] neighborNodes = new Vector2Int?[4];

                Vector2Int right = point + Vector2Int.right;
                Vector2Int down = point + Vector2Int.up;
                Vector2Int left = point + Vector2Int.left;
                Vector2Int up = point + Vector2Int.down;

                if (IsValid(right, blockCount)) neighborNodes[0] = right;
                if (IsValid(down, blockCount)) neighborNodes[1] = down;
                if (IsValid(left, blockCount)) neighborNodes[2] = left;
                if (IsValid(up, blockCount)) neighborNodes[3] = up;

                // ��� ������ ����� SetUp() �޼ҵ� ȣ��
                Node node = clone.GetComponent<Node>();
                node.Setup(board, neighborNodes, point);

                // ����� �̸��� x, y ���� ��ǥ�� ����
                clone.name = $"[{node.Point.y}, {node.Point.x}]";

                // nodeList�� ��� ������ ��� ���� ����
                nodeList.Add(node);
            }
        }

        return nodeList;
    }

    private bool IsValid(Vector2Int point, Vector2Int blockCount)
    {
        if (point.x == -1 || point.x == blockCount.x || point.y == blockCount.y || point.y == -1)
        {
            return false;
        }

        return true;
    }
}
