// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_UpdateSelfPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017E6")]
  [FlowNode.NodeType("MultiPlay/UpdateSelfPlayer", 32741)]
  [FlowNode.Pin(1, "Update", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Success", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "Failure", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("")]
  public class FlowNode_MP_UpdateSelfPlayer : FlowNode
  {
    [Token(Token = "0x4005613")]
    private const int PIN_IN_UPDATE = 1;
    [Token(Token = "0x4005614")]
    private const int PIN_OUT_SUCCESS = 11;
    [Token(Token = "0x4005615")]
    private const int PIN_OUT_FAILURE = 12;

    [Token(Token = "0x60060C4")]
    [Address(RVA = "0x135A050", Offset = "0x1358E50", VA = "0x1135A050", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060C5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_UpdateSelfPlayer()
    {
    }
  }
}
