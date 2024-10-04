using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// 0�� : ���� ������
    /// 1�� : ���� ������
    /// </summary>
    [SerializeField] GameObject[] IsCanvas = { null, null };

    /// <summary>
    /// ��ư Ŭ��
    /// </summary>
    /// <param name="argIndex">�� : ��ư Ŭ�� �ε���</param>
    public void OnBtnClick(int argIndex)
    {
        switch (argIndex)
        {
            case 0:
                Debug.Log("������");
                break;
            case 1:
                Debug.Log("������");
                break;
            case 2:
                IsCanvas[0].SetActive(false);
                IsCanvas[1].SetActive(true);
                Debug.Log("���� ������ ���� �Ϸ�");
                break;
            case 3:
                IsCanvas[0].SetActive(true);
                IsCanvas[1].SetActive(false);
                Debug.Log("���� ������ ���� �Ϸ�");
                break;
            default:
                Debug.Log("����");
                break;
        }    
    }
}
