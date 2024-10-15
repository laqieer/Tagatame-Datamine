// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRankingGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001826")]
  [FlowNode.NodeType("Raid/Req/RankingGuild", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidRankingGuild : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x600617B")]
    [Address(RVA = "0x1361570", Offset = "0x1360370", VA = "0x11361570", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x600617C")]
    [Address(RVA = "0x1361600", Offset = "0x1360400", VA = "0x11361600", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x600617D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRankingGuild()
    {
    }
  }
}
