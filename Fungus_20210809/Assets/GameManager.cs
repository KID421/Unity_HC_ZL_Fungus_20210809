using UnityEngine;
using Fungus;

public class GameManager : MonoBehaviour
{
    [Header("流程圖物件")]
    public Flowchart flowchartObject;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            flowchartObject.SendFungusMessage("按下空白鍵");
        }
    }

    /// <summary>
    /// Fungus 點擊呼叫
    /// </summary>
    public void MethodClickCall()
    {
        print("我被 Fungus 的點擊物件呼叫~");
    }
}
