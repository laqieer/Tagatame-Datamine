// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_VersusCpu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200166B")]
  [FlowNode.NodeType("VS/ReqCom", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_VersusCpu : FlowNode_Network
  {
    [Token(Token = "0x6005C11")]
    [Address(RVA = "0x1315680", Offset = "0x1314480", VA = "0x11315680", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C12")]
    [Address(RVA = "0x107A1E0", Offset = "0x1078FE0", VA = "0x1107A1E0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C13")]
    [Address(RVA = "0x13158D0", Offset = "0x13146D0", VA = "0x113158D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C14")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_VersusCpu()
    {
    }
  }
}
