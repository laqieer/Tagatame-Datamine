// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MultiPlayNeedRoomPassCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001437")]
  [FlowNode.NodeType("Multi/MultiPlayNeedRoomPassCode", 32741)]
  [FlowNode.Pin(0, "Test", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  public class FlowNode_MultiPlayNeedRoomPassCode : FlowNode
  {
    [Token(Token = "0x6005463")]
    [Address(RVA = "0x1290520", Offset = "0x128F320", VA = "0x11290520", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005464")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MultiPlayNeedRoomPassCode()
    {
    }
  }
}
