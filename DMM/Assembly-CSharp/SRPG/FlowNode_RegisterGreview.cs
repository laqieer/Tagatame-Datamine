// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RegisterGreview
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200147A")]
  [FlowNode.NodeType("System/RegisterGreview", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Register Greview", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_RegisterGreview : FlowNode_Network
  {
    [Token(Token = "0x600558C")]
    [Address(RVA = "0x129EDE0", Offset = "0x129DBE0", VA = "0x1129EDE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600558D")]
    [Address(RVA = "0x129EEE0", Offset = "0x129DCE0", VA = "0x1129EEE0")]
    private void OnSerialRegister(GameObject go)
    {
    }

    [Token(Token = "0x600558E")]
    [Address(RVA = "0x129EF80", Offset = "0x129DD80", VA = "0x1129EF80", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600558F")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005590")]
    [Address(RVA = "0x127E1B0", Offset = "0x127CFB0", VA = "0x1127E1B0")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005591")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RegisterGreview()
    {
    }
  }
}
