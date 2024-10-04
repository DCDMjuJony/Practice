using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// 0번 : 원본 프리팹
    /// 1번 : 변형 프리팹
    /// </summary>
    [SerializeField] GameObject[] IsCanvas = { null, null };

    /// <summary>
    /// 버튼 클릭
    /// </summary>
    /// <param name="argIndex">값 : 버튼 클릭 인덱스</param>
    public void OnBtnClick(int argIndex)
    {
        switch (argIndex)
        {
            case 0:
                Debug.Log("대이현");
                break;
            case 1:
                Debug.Log("대혁민");
                break;
            case 2:
                IsCanvas[0].SetActive(false);
                IsCanvas[1].SetActive(true);
                Debug.Log("변형 프리팹 생성 완료");
                break;
            case 3:
                IsCanvas[0].SetActive(true);
                IsCanvas[1].SetActive(false);
                Debug.Log("원형 프리팹 생성 완료");
                break;
            default:
                Debug.Log("조니");
                break;
        }    
    }
}
