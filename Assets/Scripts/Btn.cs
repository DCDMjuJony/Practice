using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{
    /// <summary>
    /// UI 메니저
    /// </summary>
    [SerializeField]UIManager m_UImanager;
    
    /// <summary>
    /// 버튼 인덱스
    /// </summary>
    public int m_Index = 0;

    /// <summary>
    /// 버튼 클릭 시 UI Manager의 OnbtnClick 호출
    /// </summary>
    /// <param name="argIndex"></param>
    public void OnBtnClick(int argIndex)
    {
        m_UImanager.OnBtnClick(argIndex);
    }
}
