// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_NewGameEmailRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001443")]
  [FlowNode.NodeType("System/NewGame/NewEmailGameRegister", 32741)]
  [FlowNode.Pin(0, "Create New Account", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_NewGameEmailRegister : FlowNode
  {
    [Token(Token = "0x4004AF5")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x4004AF6")]
    private const int PIN_SUCCESS = 10;
    [Token(Token = "0x4004AF7")]
    private const int PIN_FAILED = 11;

    [Token(Token = "0x60054AE")]
    [Address(RVA = "0x1292AA0", Offset = "0x12918A0", VA = "0x11292AA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054AF")]
    [Address(RVA = "0x1292A00", Offset = "0x1291800", VA = "0x11292A00")]
    private void ImmediateResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x60054B0")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_NewGameEmailRegister()
    {
    }
  }
}
