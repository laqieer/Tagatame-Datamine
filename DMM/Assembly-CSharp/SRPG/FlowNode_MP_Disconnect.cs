// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_Disconnect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017B2")]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "Disconnect", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("MultiPlay/Photon/MultiPlayDisconnect", 13618982)]
  [AddComponentMenu("")]
  public class FlowNode_MP_Disconnect : FlowNode
  {
    [Token(Token = "0x4005567")]
    private const int PIN_IN_DISCONNECT = 0;
    [Token(Token = "0x4005568")]
    private const int PIN_OUT_SUCCESS = 10;

    [Token(Token = "0x6006017")]
    [Address(RVA = "0x134B570", Offset = "0x134A370", VA = "0x1134B570", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006018")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_Disconnect()
    {
    }
  }
}
