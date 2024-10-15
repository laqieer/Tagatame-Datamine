// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200181F")]
  [FlowNode.NodeType("Raid/Req/Index", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaid : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x600615B")]
    [Address(RVA = "0x1363B70", Offset = "0x1362970", VA = "0x11363B70", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x600615C")]
    [Address(RVA = "0x1363C00", Offset = "0x1362A00", VA = "0x11363C00", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x600615D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaid()
    {
    }
  }
}
