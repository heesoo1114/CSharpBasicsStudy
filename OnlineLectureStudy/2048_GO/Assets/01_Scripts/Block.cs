using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class Block : MonoBehaviour
{
    [SerializeField] private Color[] blockColors; // ����� ���� �� �ִ� ��� ����
    [SerializeField] private Image imageBlock; // ��� ���� ������ ���� Image
    [SerializeField] private TextMeshProUGUI textBlockNumeric; // ��� ���� �׽�Ʈ ������ ���� Text

    private int numeric; // ����� ������ ����
    private bool combine = false; // �ش� ����� ���� ���� (��� �̵��� ����ǰ� ���� �������ֱ� ����) 

    // �̵� or ���� ���� �̵��ϴ� ��ǥ Node
    public Node Target { get; set; }

    public bool NeedDestory { get; set; } = false;
    
    public int Numeric
    {
        set
        {
            // ���� ���� �� ����, ��Ͽ� ��µǴ� ���� ����, ����� ���� ����
            numeric = value;
            textBlockNumeric.text = value.ToString();
            imageBlock.color = blockColors[(int)Mathf.Log(value, 2) - 1];
            // ex) Log(8, 2) = log(small"2")8 = 3
        }
        get => numeric;
    }

    public void Setup()
    {
        Numeric = Random.Range(0, 100) < 90 ? 2 : 4;
        StartCoroutine(OnScaleAnimation(Vector3.one * 0.5f, Vector3.one, 0.15f));
    }

    public void MoveToNode(Node to)
    {
        Target = to;
        combine = false;
    }

    public void CombineToNode(Node to)
    {
        Target = to;
        combine = true;
    }

    public void StartMove()
    {
        float moveTime = 0.1f;
        StartCoroutine(OnLocalMoveAnimation(Target.localPosition, moveTime, OnAfterMove));
    }

    private void OnAfterMove()
    {
        if (Target != null)
        {
            if (combine) // ���յǴ� ���
            {
                // ����� ���յǾ��� ������ ��ǥ ����� ���ڵ� x2
                Target.placedBlock.Numeric *= 2;
                // ��ǥ ����� Ȯ��/��� �ִϸ��̼� ���
                Target.placedBlock.StartPunchScale(Vector3.one * 0.25f, 0.15f, OnAfterAnimation);
                // ���� ����� ��Ȱ��ȭ
                gameObject.SetActive(false);
            }
            else // �̵��ϴ� ���
            {
                // ��ǥ(Target) ��ġ���� �̵��� �Ϸ��߱� ������ ��ǥ ����
                Target = null;
            }
        }
    }

    public void StartPunchScale(Vector3 punch, float time, UnityAction action = null)
    {
        StartCoroutine(OnPunchScale(punch, time, action));
    }

    private void OnAfterAnimation()
    {
        Target = null;
        NeedDestory = true;
    }

    private IEnumerator OnPunchScale(Vector3 punch, float time, UnityAction action)
    {
        Vector3 current = Vector3.one;
        yield return StartCoroutine(OnScaleAnimation(current, current + punch, time * 0.5f));
        yield return StartCoroutine(OnScaleAnimation(current + punch, current, time * 0.5f));
        action?.Invoke();
    }

    private IEnumerator OnScaleAnimation(Vector3 start, Vector3 end, float time)
    {
        float current = 0;
        float percent = 0;

        while (percent < 1)
        {
            current += Time.deltaTime;
            percent = current / time;

            transform.localScale = Vector3.Lerp(start, end, percent);

            yield return null;
        }
    }

    private IEnumerator OnLocalMoveAnimation(Vector3 end, float time, UnityAction action)
    {
        float current = 0;
        float percent = 0;
        Vector3 start = GetComponent<RectTransform>().localPosition;

        while (percent < 1)
        {
            current += Time.deltaTime;
            percent = current / time;

            transform.localPosition = Vector3.Lerp(start, end, percent);

            yield return null;
        }

        if (action != null) action.Invoke();
    }
}
