// Decompiled with JetBrains decompiler
// Type: SRPG.StoryExChallengeCountResetConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002867")]
  [AddComponentMenu("UI/Quest/StoryExChallengeCountResetConfirm")]
  [FlowNode.Pin(100, "初期化完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  public class StoryExChallengeCountResetConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C105")]
    private const int PIN_INPUT_INIT_START = 10;
    [Token(Token = "0x400C106")]
    private const int PIN_OUTPUT_INIT_END = 100;
    [Token(Token = "0x400C107")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private eResetCostType mCostType;
    [Token(Token = "0x400C108")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mConfirmText;
    [Token(Token = "0x400C109")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mBeforeNum;
    [Token(Token = "0x400C10A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mAfterNum;
    [Token(Token = "0x400C10B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mRestResetCount;
    [Token(Token = "0x400C10C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mItemIcon;

    [Token(Token = "0x600B697")]
    [Address(RVA = "0x7DCFB0", Offset = "0x7DBDB0", VA = "0x107DCFB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B698")]
    [Address(RVA = "0x7DD690", Offset = "0x7DC490", VA = "0x107DD690")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B699")]
    [Address(RVA = "0x7DD250", Offset = "0x7DC050", VA = "0x107DD250")]
    private void Refresh_Item()
    {
    }

    [Token(Token = "0x600B69A")]
    [Address(RVA = "0x7DD000", Offset = "0x7DBE00", VA = "0x107DD000")]
    private void Refresh_Coin()
    {
    }

    [Token(Token = "0x600B69B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public StoryExChallengeCountResetConfirm()
    {
    }
  }
}
