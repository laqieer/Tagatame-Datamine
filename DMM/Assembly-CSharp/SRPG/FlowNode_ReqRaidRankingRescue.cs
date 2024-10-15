// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRankingRescue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001827")]
  [FlowNode.NodeType("Raid/Req/RankingRescue", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidRankingRescue : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x600617E")]
    [Address(RVA = "0x1361850", Offset = "0x1360650", VA = "0x11361850", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x600617F")]
    [Address(RVA = "0x13619A0", Offset = "0x13607A0", VA = "0x113619A0", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x6006180")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRankingRescue()
    {
    }
  }
}
