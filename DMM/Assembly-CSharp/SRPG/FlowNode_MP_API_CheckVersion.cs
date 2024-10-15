// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_API_CheckVersion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001777")]
  [FlowNode.Pin(1, "Check Version", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/API/CheckVersion", 32741)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "Version Mismatch", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "Maintenance", FlowNode.PinTypes.Output, 202)]
  [AddComponentMenu("")]
  public class FlowNode_MP_API_CheckVersion : FlowNode_Network
  {
    [Token(Token = "0x4005457")]
    private const int PIN_IN_CHECK_VERSION = 1;
    [Token(Token = "0x4005458")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x4005459")]
    private const int PIN_OUT_VERSION_MISMATCH = 201;
    [Token(Token = "0x400545A")]
    private const int PIN_OUT_MAINTENANCE = 202;

    [Token(Token = "0x6005F2E")]
    [Address(RVA = "0x13316E0", Offset = "0x13304E0", VA = "0x113316E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005F2F")]
    [Address(RVA = "0x1331780", Offset = "0x1330580", VA = "0x11331780", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005F30")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_MP_API_CheckVersion()
    {
    }
  }
}
