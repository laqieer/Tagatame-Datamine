// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MultiPlayTestRoomPassCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001438")]
  [FlowNode.NodeType("Multi/MultiPlayTestRoomPassCode", 32741)]
  [FlowNode.Pin(0, "Test", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "OK", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(2, "NG", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  public class FlowNode_MultiPlayTestRoomPassCode : FlowNode
  {
    [Token(Token = "0x6005465")]
    [Address(RVA = "0x12905D0", Offset = "0x128F3D0", VA = "0x112905D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005466")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MultiPlayTestRoomPassCode()
    {
    }
  }
}
