// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LocalVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001426")]
  [AddComponentMenu("")]
  [FlowNode.Pin(22, "Not Equal", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(21, "Equal", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(11, "Set", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("Common/LocalVariable", 14209165)]
  [FlowNode.Pin(1, "Set", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "SetIfNull", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Compare", FlowNode.PinTypes.Input, 2)]
  public class FlowNode_LocalVariable : FlowNode
  {
    [Token(Token = "0x4004A92")]
    private const int PIN_IN_SET = 1;
    [Token(Token = "0x4004A93")]
    private const int PIN_IN_COMPARE = 2;
    [Token(Token = "0x4004A94")]
    private const int PIN_IN_SET_IF_NULL = 3;
    [Token(Token = "0x4004A95")]
    private const int PIN_OUT_SET = 11;
    [Token(Token = "0x4004A96")]
    private const int PIN_OUT_EQUAL = 21;
    [Token(Token = "0x4004A97")]
    private const int PIN_OUT_NOT_EQUAL = 22;
    [Token(Token = "0x4004A98")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.ShowInInfo]
    public string Key;
    [Token(Token = "0x4004A99")]
    [FieldOffset(Offset = "0x1C")]
    [FlowNode.ShowInInfo]
    public string Value;

    [Token(Token = "0x6005420")]
    [Address(RVA = "0x128CC00", Offset = "0x128BA00", VA = "0x1128CC00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005421")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_LocalVariable()
    {
    }
  }
}
