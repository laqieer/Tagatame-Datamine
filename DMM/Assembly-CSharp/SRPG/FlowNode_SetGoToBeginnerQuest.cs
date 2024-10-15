// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetGoToBeginnerQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001618")]
  [FlowNode.NodeType("System/SetGoToBeginnerQuest", 32741)]
  [FlowNode.Pin(1, "SetFalse", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Result", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "SetTrue", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_SetGoToBeginnerQuest : FlowNode
  {
    [Token(Token = "0x4005018")]
    [FieldOffset(Offset = "0x18")]
    public string Name;
    [Token(Token = "0x4005019")]
    private const int IN_SET_TRUE = 0;
    [Token(Token = "0x400501A")]
    private const int IN_SET_FALSE = 1;
    [Token(Token = "0x400501B")]
    private const int OUT_RESULT = 100;

    [Token(Token = "0x6005AE3")]
    [Address(RVA = "0x12F9F10", Offset = "0x12F8D10", VA = "0x112F9F10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AE4")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetGoToBeginnerQuest()
    {
    }
  }
}
