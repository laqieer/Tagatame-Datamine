// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardEntranceButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002713")]
  [FlowNode.Pin(111, "表示：完了", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(1, "設定", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "再度通信", FlowNode.PinTypes.Output, 101)]
  public class MasteryRewardEntranceButton : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B823")]
    private const int PIN_IN_SETUP = 1;
    [Token(Token = "0x400B824")]
    private const int PIN_OUT_REQUEST = 101;
    [Token(Token = "0x400B825")]
    private const int PIN_OUT_DISPLAY_END = 111;
    [Token(Token = "0x400B826")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B827")]
    [FieldOffset(Offset = "0x10")]
    private MasteryRewardEntranceButtonModel mModel;

    [Token(Token = "0x600AF28")]
    [Address(RVA = "0x735D30", Offset = "0x734B30", VA = "0x10735D30")]
    public void OnEnable()
    {
    }

    [Token(Token = "0x600AF29")]
    [Address(RVA = "0x735C10", Offset = "0x734A10", VA = "0x10735C10")]
    public bool Initialize() => new bool();

    [Token(Token = "0x600AF2A")]
    [Address(RVA = "0x735B20", Offset = "0x734920", VA = "0x10735B20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AF2B")]
    [Address(RVA = "0x735D60", Offset = "0x734B60", VA = "0x10735D60")]
    private void Setup()
    {
    }

    [Token(Token = "0x600AF2C")]
    [Address(RVA = "0x735CB0", Offset = "0x734AB0", VA = "0x10735CB0")]
    public bool IsHomeUnitList() => new bool();

    [Token(Token = "0x600AF2D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryRewardEntranceButton()
    {
    }
  }
}
