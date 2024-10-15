// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceEventTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F4F")]
  [AddComponentMenu("UI/Advance/AdvanceEventTop")]
  [FlowNode.Pin(112, "イベントアーカイブ用の戻る（復刻専用の戻る）", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(101, "Initialized", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "戻るボタン", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "AdvanceQuestList.unityへ戻る（通常の戻る）", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(12, "アーカイブ用の開催チェック", FlowNode.PinTypes.Input, 12)]
  public class AdvanceEventTop : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x40083E5")]
    public const int PIN_IN_INIT = 1;
    [Token(Token = "0x40083E6")]
    public const int PIN_IN_BUTTON_BACK = 11;
    [Token(Token = "0x40083E7")]
    public const int PIN_IN_CHECK = 12;
    [Token(Token = "0x40083E8")]
    public const int PIN_OUT_INIT = 101;
    [Token(Token = "0x40083E9")]
    private const int PIN_OUT_BACK_MENU_ADVANCEQUEST = 111;
    [Token(Token = "0x40083EA")]
    private const int PIN_OUT_BACK_MENU_DAILY = 112;
    [Token(Token = "0x40083EB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mBGParent;
    [Token(Token = "0x40083EC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject[] mBossButtonGO;

    [Token(Token = "0x6008060")]
    [Address(RVA = "0x40B330", Offset = "0x40A130", VA = "0x1040B330", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008061")]
    [Address(RVA = "0x40B640", Offset = "0x40A440", VA = "0x1040B640")]
    private bool Init() => new bool();

    [Token(Token = "0x6008062")]
    [Address(RVA = "0x40B810", Offset = "0x40A610", VA = "0x1040B810")]
    private void SetupBossButton(GameObject buttonGO, QuestDifficulties difficulty)
    {
    }

    [Token(Token = "0x6008063")]
    [Address(RVA = "0x40B480", Offset = "0x40A280", VA = "0x1040B480")]
    private void Downloaded(GameObject prefab)
    {
    }

    [Token(Token = "0x6008064")]
    [Address(RVA = "0x40B530", Offset = "0x40A330", VA = "0x1040B530", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x6008065")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceEventTop()
    {
    }
  }
}
