// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_MultiTowerUpdateRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017B1")]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Update Pass", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(102, "Failure", FlowNode.PinTypes.Output, 102)]
  [FlowNode.NodeType("MultiPlay/MultiTower/UpdateRoom", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Update Floor", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_MP_MultiTowerUpdateRoom : FlowNode
  {
    [Token(Token = "0x4005563")]
    private const int PIN_IN_UPDATE_FLOOR = 1;
    [Token(Token = "0x4005564")]
    private const int PIN_IN_UPDATE_PASS = 2;
    [Token(Token = "0x4005565")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005566")]
    private const int PIN_OUT_FAILURE = 102;

    [Token(Token = "0x6006015")]
    [Address(RVA = "0x134E390", Offset = "0x134D190", VA = "0x1134E390", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006016")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_MultiTowerUpdateRoom()
    {
    }
  }
}
