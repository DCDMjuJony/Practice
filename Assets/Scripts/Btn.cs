using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{
    /// <summary>
    /// UI �޴���
    /// </summary>
    [SerializeField]UIManager m_UImanager;
    
    /// <summary>
    /// ��ư �ε���
    /// </summary>
    public int m_Index = 0;

    /// <summary>
    /// ��ư Ŭ�� �� UI Manager�� OnbtnClick ȣ��
    /// </summary>
    /// <param name="argIndex"></param>
    public void OnBtnClick(int argIndex)
    {
        m_UImanager.OnBtnClick(argIndex);
    }
}
