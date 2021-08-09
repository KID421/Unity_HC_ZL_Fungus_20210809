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
}
