// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetForceSceneChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001617")]
  [FlowNode.Pin(1, "False", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Scene/SetForceSceneChange", 32741)]
  [FlowNode.Pin(0, "True", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  public class FlowNode_SetForceSceneChange : FlowNode
  {
    [Token(Token = "0x4005015")]
    private const int PIN_IN_TRUE = 0;
    [Token(Token = "0x4005016")]
    private const int PIN_IN_FALSE = 1;
    [Token(Token = "0x4005017")]
    private const int PIN_OUT = 100;

    [Token(Token = "0x6005AE1")]
    [Address(RVA = "0x12F9E80", Offset = "0x12F8C80", VA = "0x112F9E80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AE2")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetForceSceneChange()
    {
    }
  }
}
