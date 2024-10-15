// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001831")]
  [FlowNode.NodeType("Raid/Req/Round", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidRound : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x60061A1")]
    [Address(RVA = "0x13635F0", Offset = "0x13623F0", VA = "0x113635F0", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x60061A2")]
    [Address(RVA = "0x1363680", Offset = "0x1362480", VA = "0x11363680", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x60061A3")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRound()
    {
    }
  }
}
