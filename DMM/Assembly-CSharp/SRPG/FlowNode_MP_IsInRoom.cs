// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_IsInRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017B6")]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Is in Room", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("MultiPlay/Photon/IsInRoom", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(102, "Is Not in Room", FlowNode.PinTypes.Output, 102)]
  public class FlowNode_MP_IsInRoom : FlowNode
  {
    [Token(Token = "0x400556F")]
    private const int PIN_IN_CHECK = 1;
    [Token(Token = "0x4005570")]
    private const int PIN_OUT_IS_IN_ROOM = 101;
    [Token(Token = "0x4005571")]
    private const int PIN_OUT_IS_NOT_IN_ROOM = 102;

    [Token(Token = "0x6006026")]
    [Address(RVA = "0x134B980", Offset = "0x134A780", VA = "0x1134B980", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006027")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_IsInRoom()
    {
    }
  }
}
