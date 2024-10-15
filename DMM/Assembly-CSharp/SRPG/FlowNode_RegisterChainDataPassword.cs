// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RegisterChainDataPassword
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001479")]
  [FlowNode.NodeType("System/NewGame/NewChainDataPasswordRegister", 32741)]
  [FlowNode.Pin(10, "start", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "end", FlowNode.PinTypes.Output, 20)]
  [AddComponentMenu("")]
  public class FlowNode_RegisterChainDataPassword : FlowNode
  {
    [Token(Token = "0x4004BBA")]
    private const int PIN_IN = 10;
    [Token(Token = "0x4004BBB")]
    private const int PIN_OUT = 20;

    [Token(Token = "0x6005588")]
    [Address(RVA = "0x129ED20", Offset = "0x129DB20", VA = "0x1129ED20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005589")]
    [Address(RVA = "0x129EC90", Offset = "0x129DA90", VA = "0x1129EC90")]
    private string CreatePassword() => (string) null;

    [Token(Token = "0x600558A")]
    [Address(RVA = "0x129ED40", Offset = "0x129DB40", VA = "0x1129ED40")]
    private void RegisterCallback(RegisterEmailAddressAndPasswordResult res)
    {
    }

    [Token(Token = "0x600558B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RegisterChainDataPassword()
    {
    }
  }
}
