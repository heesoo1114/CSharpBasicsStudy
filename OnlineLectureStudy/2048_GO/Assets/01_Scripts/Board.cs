using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State { Wait  = 0, Processing, End } // ( ���, �̵� or ����, ��ó�� )

public class Board : MonoBehaviour
{
    [SerializeField] private NodeSpawner nodeSpawner;
    [SerializeField] private TouchController touchController;

    [SerializeField] private GameObject blockPrefab; // ��� ���� ������
    [SerializeField] private Transform blockRect; // ������ ��ϵ��� �θ� Transform

    public List<Node> NodeList { private set; get; }
    public Vector2Int BlockCount { private set; get; }

    private List<Block> blockList;
    private State state = State.Wait; // ���� ����

    private void Awake()
    {
        // ����� ������ 4x4 ũ��� ����
        BlockCount = new Vector2Int(4, 4);

        // ��� ��� �� ����, ��� ����� ������ NodeList�� ����
        NodeList = nodeSpawner.SpawnNodes(this, BlockCount);

        blockList = new List<Block>();
    }

    private void Start()
    {
        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(nodeSpawner.GetComponent<RectTransform>());

        foreach ( Node node in NodeList )
        {
            node.localPosition = node.GetComponent<RectTransform>().localPosition;
        }

        SpawnBlockToRandomNode();
        SpawnBlockToRandomNode();
    }

    private void Update()
    {
        if (IsGameOver())
        {
            OnGameOver();
        }

        if (state == State.Wait)
        {
            Direction direction = touchController.UpdateTouch();

            if (direction != Direction.None)
            {
                AllBlockProcess(direction);
            }
        }
        else
        {
            UpdateState();
        }
    }

    private void SpawnBlockToRandomNode()
    {
        #region �Ʒ� �ڵ�� ������ ���
        /*List<Node> emptyNodes = new List<Node>();

        foreach ( Node node in NodeList )
        {
            if (node.placedBlock = null)
            {
                emptyNodes.Add(node);
            }
        }*/
        #endregion
        List<Node> emptyNodes = NodeList.FindAll(x => x.placedBlock == null);

        // ����� ��ġ�Ǿ� ���� ���� ��尡 ���� ��
        if (emptyNodes.Count != 0)
        {
            // ����� ��ġ�Ǿ� ���� ���� ��� �� ������ ��带 �������� ��������
            // �������� ������ ����� point ������ �����´�
            int index = Random.Range(0, emptyNodes.Count);
            Vector2Int point = emptyNodes[index].Point;

            SpawnBlock(point.x, point.y);
        }
        else
        {
            if (IsGameOver())
            {
                OnGameOver();
            }
        }
    }

    private void SpawnBlock(int x, int y)
    {
        // �ش� ��ġ�� ����� ��ġ�Ǿ� ������ return
        if (NodeList[y * BlockCount.x + x].placedBlock != null) return;

        GameObject clone = Instantiate(blockPrefab, blockRect);
        Block block = clone.GetComponent<Block>();
        Node node = NodeList[y * BlockCount.x + x];

        // ������ ����� ��ġ�� ����� ��ġ�� �����ϰ� ����
        clone.GetComponent<RectTransform>().localPosition = node.localPosition;

        // ����� ó�� ������ �� ���� ���� 
        block.Setup();

        // ��� ������ ����� ��忡 ���
        node.placedBlock = block;

        // ����Ʈ�� ��� ���� ����
        blockList.Add(block);
    }

    private void AllBlockProcess(Direction direction)
    {
        if (direction == Direction.Right)
        {
            for (int y = 0; y < BlockCount.y; ++y)
            {
                for (int x = (BlockCount.x - 2); x >= 0; --x)
                {
                    BlockProcess(NodeList[y * BlockCount.x + x], direction);
                }
            }
        }
        else if (direction == Direction.Down)
        {
            for (int y = (BlockCount.y - 2); y >= 0; --y)
            {
                for (int x = 0; x < BlockCount.x; ++x)
                {
                    BlockProcess(NodeList[y * BlockCount.x + x], direction);
                }
            }
        }
        else if (direction == Direction.Left)
        {
            for (int y = 0; y < BlockCount.y; ++y)
            {
                for (int x = 1; x < BlockCount.x; ++x)
                {
                    BlockProcess(NodeList[y * BlockCount.x + x], direction);
                }
            }
        }
        else if (direction == Direction.Up)
        {
            for (int y = 1; y < BlockCount.y; ++y)
            {
                for (int x = 0; x < BlockCount.x; ++x)
                {
                    BlockProcess(NodeList[y * BlockCount.x + x], direction);
                }
            }
        }

        foreach (Block block in blockList)
        {
            if (block.Target != null)
            {
                state = State.Processing;
                block.StartMove();
            }
        }

        if (IsGameOver())
        {
            OnGameOver();
        }
    }

    // node�� ��ġ�Ǿ� �ִ� ����� direction �������� �̵� or ���� ó��
    private void BlockProcess(Node node, Direction direction)
    {
        if (node.placedBlock == null) return;

        // �ش���⿡ �ִ� ��� �˻�
        Node neighborNode = node.FindTarget(node, direction);

        if (neighborNode != null)
        {
            // ���� ���� �ƿ���忡 ����� �ְ�, �� ����� ���� ������ ���� 
            if (node.placedBlock != null && neighborNode.placedBlock != null)
            {
                if (node.placedBlock.Numeric == neighborNode.placedBlock.Numeric)
                {
                    Combine(node, neighborNode);
                }
            }
            // �̵��Ϸ��� ���⿡ ���� ������ ����� ������ ��尡 ����ֱ� ������ �̵�
            else if (neighborNode != null && neighborNode.placedBlock == null)
            {
                Move(node, neighborNode);
            }
        }
    }

    // from ��忡 �ִ� ����� to ���� �̵�
    private void Move(Node from, Node to)
    {
        // from ��忡 �ִ� ����� ��ǥ ��带 to ���� ����
        from.placedBlock.MoveToNode(to);

        if (from.placedBlock != null)
        {
            to.placedBlock = from.placedBlock;
            from.placedBlock = null;
        }
    }

    private void Combine(Node from, Node to)
    {
        // from ��忡 ������ ����� to ��忡 �ִ� ��Ͽ� ���յǵ��� ����
        from.placedBlock.CombineToNode(to);
        // from ����� ��� ������ �����
        from.placedBlock = null;
        // to ����� combined = true ������ ���յǴ� ���� ����
        to.Combined = true;
    }

    private void UpdateState()
    {
        // ��� ����� �̵�, ���� ó���� �������̸� false
        // ��� ����� �̵�, ���� ó���� �Ϸ�Ǹ� true
        bool targetAllNull = true;

        foreach (Block block in blockList)
        {
            if (block.Target != null)
            {
                targetAllNull = false;
                break;
            }
        }

        if (targetAllNull && state == State.Processing)
        {
            List<Block> removeBlocks = new List<Block>();

            foreach (Block block in blockList)
            {
                if (block.NeedDestory)
                {
                    removeBlocks.Add(block);
                }
            }

            removeBlocks.ForEach(x =>
            {
                blockList.Remove(x);
                Destroy(x.gameObject);
            });

            state = State.End;
        }

        if (state == State.End)
        {
            state = State.Wait;

            SpawnBlockToRandomNode();

            NodeList.ForEach(x => x.Combined = false);
        }
    }

    private bool IsGameOver()
    {
        foreach (Node node in NodeList)
        {
            // ���� ��忡 ����� ������ ���� ���� ����
            if (node.placedBlock == null) return false;

            // �� ����� �̿�  ��� ������ŭ �ݺ�
            for (int i =  0;  i < node.NeighborNodes.Length; ++i)
            {
                // �̿� ��尡 ������ �ǳʶڴ�. (�ٱ��� ����)
                if (node.NeighborNodes[i] == null) continue;

                // �̿� ����� ���� ��������
                Vector2Int point = node.NeighborNodes[i].Value;
                Node neighborNode = NodeList[point.y * BlockCount.x + point.x];

                if (node.placedBlock != null && neighborNode.placedBlock != null)
                {
                    if (node.placedBlock.Numeric == neighborNode.placedBlock.Numeric)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    private void OnGameOver()
    {
        Debug.Log("Game Over");
    }
}
