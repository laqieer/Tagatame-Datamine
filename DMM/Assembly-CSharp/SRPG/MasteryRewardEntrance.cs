// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardEntrance
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
  [Token(Token = "0x2002712")]
  [FlowNode.Pin(121, "ボタンの初期化", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(111, "オブジェクトの表示", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(11, "表示", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class MasteryRewardEntrance : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B81D")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B81E")]
    private const int PIN_IN_DISPLAY = 11;
    [Token(Token = "0x400B81F")]
    private const int PIN_OUT_DISPLAY = 111;
    [Token(Token = "0x400B820")]
    private const int PIN_OUT_BUTTON_INIT = 121;
    [Token(Token = "0x400B821")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B822")]
    [FieldOffset(Offset = "0x10")]
    private MasteryRewardEntranceModel mModel;

    [Token(Token = "0x600AF24")]
    [Address(RVA = "0x735EC0", Offset = "0x734CC0", VA = "0x10735EC0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600AF25")]
    [Address(RVA = "0x735DB0", Offset = "0x734BB0", VA = "0x10735DB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AF26")]
    [Address(RVA = "0x735F40", Offset = "0x734D40", VA = "0x10735F40")]
    private void Setup()
    {
    }

    [Token(Token = "0x600AF27")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryRewardEntrance()
    {
    }
  }
}
