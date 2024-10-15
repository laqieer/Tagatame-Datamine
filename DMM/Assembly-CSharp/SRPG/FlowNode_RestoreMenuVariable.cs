// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RestoreMenuVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015F3")]
  [FlowNode.Pin(12, "!= Variable", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("Scene/RestoreMenuVariable", 32741)]
  [FlowNode.Pin(0, "Set", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1, "Compare", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "Assigned", FlowNode.PinTypes.Output, 9)]
  [FlowNode.Pin(11, "== Variable", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_RestoreMenuVariable : FlowNode
  {
    [Token(Token = "0x4004FA1")]
    private const int PIN_ID_SET = 0;
    [Token(Token = "0x4004FA2")]
    private const int PIN_ID_COMPARE = 1;
    [Token(Token = "0x4004FA3")]
    private const int PIN_ID_ASSIGNED = 10;
    [Token(Token = "0x4004FA4")]
    private const int PIN_ID_EQUAL = 11;
    [Token(Token = "0x4004FA5")]
    private const int PIN_ID_UNEQUAL = 12;
    [Token(Token = "0x4004FA6")]
    [FieldOffset(Offset = "0x18")]
    public RestorePoints RestorePoint;
    [Token(Token = "0x4004FA7")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public RestorePoints ResetRestorePoint;
    [Token(Token = "0x4004FA8")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public bool AutoReset;

    [Token(Token = "0x6005A2A")]
    [Address(RVA = "0x12EB860", Offset = "0x12EA660", VA = "0x112EB860", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A2B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RestoreMenuVariable()
    {
    }
  }
}
