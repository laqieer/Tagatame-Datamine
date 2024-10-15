// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRankingBeat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001825")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Raid/Req/RankingBeat", 32741)]
  public class FlowNode_ReqRaidRankingBeat : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x6006178")]
    [Address(RVA = "0x1361280", Offset = "0x1360080", VA = "0x11361280", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006179")]
    [Address(RVA = "0x13613D0", Offset = "0x13601D0", VA = "0x113613D0", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x600617A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRankingBeat()
    {
    }
  }
}
