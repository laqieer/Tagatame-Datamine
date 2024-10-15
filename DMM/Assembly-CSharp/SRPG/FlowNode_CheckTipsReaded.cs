// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckTipsReaded
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200138C")]
  [FlowNode.Pin(2, "True", FlowNode.PinTypes.Output, 2)]
  [FlowNode.NodeType("Tips/CheckTipsReaded", 32741)]
  [FlowNode.Pin(1, "既読か？", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "False", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("")]
  public class FlowNode_CheckTipsReaded : FlowNode
  {
    [Token(Token = "0x400483C")]
    private const int PIN_ID_IN = 1;
    [Token(Token = "0x400483D")]
    private const int PIN_ID_TRUE = 2;
    [Token(Token = "0x400483E")]
    private const int PIN_ID_FALSE = 3;
    [Token(Token = "0x400483F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string Tips;

    [Token(Token = "0x60051F6")]
    [Address(RVA = "0x126D650", Offset = "0x126C450", VA = "0x1126D650", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051F7")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckTipsReaded()
    {
    }
  }
}
