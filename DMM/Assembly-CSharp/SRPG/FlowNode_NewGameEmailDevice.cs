// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_NewGameEmailDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001442")]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("System/NewGame/NewGameEmailDevice", 32741)]
  [FlowNode.Pin(0, "Chain New Account", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_NewGameEmailDevice : FlowNode
  {
    [Token(Token = "0x4004AF2")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x4004AF3")]
    private const int PIN_SUCCESS = 10;
    [Token(Token = "0x4004AF4")]
    private const int PIN_FAILED = 11;

    [Token(Token = "0x60054AB")]
    [Address(RVA = "0x1292890", Offset = "0x1291690", VA = "0x11292890", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054AC")]
    [Address(RVA = "0x1292820", Offset = "0x1291620", VA = "0x11292820")]
    private void AddUserResponse(AddDeviceWithEmailAddressAndPasswordResult res)
    {
    }

    [Token(Token = "0x60054AD")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_NewGameEmailDevice()
    {
    }
  }
}
