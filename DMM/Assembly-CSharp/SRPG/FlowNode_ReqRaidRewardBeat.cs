// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRewardBeat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200182F")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Raid/Req/Reward/Beat", 32741)]
  public class FlowNode_ReqRaidRewardBeat : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x600619B")]
    [Address(RVA = "0x1362D90", Offset = "0x1361B90", VA = "0x11362D90", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x600619C")]
    [Address(RVA = "0x13630A0", Offset = "0x1361EA0", VA = "0x113630A0", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x600619D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRewardBeat()
    {
    }
  }
}
