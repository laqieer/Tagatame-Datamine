// Decompiled with JetBrains decompiler
// Type: SRPG.StoryExTotalChallengeCountResetConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002869")]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "初期化完了", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/Quest/StoryExTotalChallengeCountResetConfirm")]
  public class StoryExTotalChallengeCountResetConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C111")]
    private const int PIN_INPUT_INIT_START = 10;
    [Token(Token = "0x400C112")]
    private const int PIN_OUTPUT_INIT_END = 100;
    [Token(Token = "0x400C113")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private eResetCostType mCostType;
    [Token(Token = "0x400C114")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mConfirmText;
    [Token(Token = "0x400C115")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mBeforeNum;
    [Token(Token = "0x400C116")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mAfterNum;
    [Token(Token = "0x400C117")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mRestResetCount;
    [Token(Token = "0x400C118")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mItemIcon;

    [Token(Token = "0x600B69F")]
    [Address(RVA = "0x7DD870", Offset = "0x7DC670", VA = "0x107DD870", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B6A0")]
    [Address(RVA = "0x7DDF70", Offset = "0x7DCD70", VA = "0x107DDF70")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B6A1")]
    [Address(RVA = "0x7DDB30", Offset = "0x7DC930", VA = "0x107DDB30")]
    private void Refresh_Item()
    {
    }

    [Token(Token = "0x600B6A2")]
    [Address(RVA = "0x7DD8C0", Offset = "0x7DC6C0", VA = "0x107DD8C0")]
    private void Refresh_Coin()
    {
    }

    [Token(Token = "0x600B6A3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public StoryExTotalChallengeCountResetConfirm()
    {
    }
  }
}
