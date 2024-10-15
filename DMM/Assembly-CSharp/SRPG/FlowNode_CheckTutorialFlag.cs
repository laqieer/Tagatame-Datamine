// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckTutorialFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200138D")]
  [AddComponentMenu("")]
  [FlowNode.Pin(3, "False", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(1, "CheckFlag", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Tutorial/CheckTutorialFlag", 32741)]
  [FlowNode.Pin(2, "True", FlowNode.PinTypes.Output, 0)]
  public class FlowNode_CheckTutorialFlag : FlowNode
  {
    [Token(Token = "0x4004840")]
    private const int PIN_ID_IN = 1;
    [Token(Token = "0x4004841")]
    private const int PIN_ID_TRUE = 2;
    [Token(Token = "0x4004842")]
    private const int PIN_ID_FALSE = 3;
    [Token(Token = "0x4004843")]
    [FieldOffset(Offset = "0x18")]
    public TutorialFlags mTutorialFlags;
    [Token(Token = "0x4004844")]
    [FieldOffset(Offset = "0x1C")]
    public string FlagID;

    [Token(Token = "0x60051F9")]
    [Address(RVA = "0x126D8D0", Offset = "0x126C6D0", VA = "0x1126D8D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051FA")]
    [Address(RVA = "0x126D830", Offset = "0x126C630", VA = "0x1126D830")]
    private bool CheckFlag(TutorialFlags flag) => new bool();

    [Token(Token = "0x60051FB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckTutorialFlag()
    {
    }
  }
}
