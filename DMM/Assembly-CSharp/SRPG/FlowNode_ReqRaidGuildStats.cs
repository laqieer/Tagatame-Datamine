// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidGuildStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001821")]
  [FlowNode.NodeType("Raid/Req/GuildStats", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidGuildStats : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x6006165")]
    [Address(RVA = "0x1360050", Offset = "0x135EE50", VA = "0x11360050", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006166")]
    [Address(RVA = "0x1360120", Offset = "0x135EF20", VA = "0x11360120", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x6006167")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidGuildStats()
    {
    }
  }
}
