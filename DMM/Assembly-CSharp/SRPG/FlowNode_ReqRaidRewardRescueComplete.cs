// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRewardRescueComplete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001830")]
  [FlowNode.NodeType("Raid/Req/Reward/RescueComplete ", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidRewardRescueComplete : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x600619E")]
    [Address(RVA = "0x1363310", Offset = "0x1362110", VA = "0x11363310", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x600619F")]
    [Address(RVA = "0x13633A0", Offset = "0x13621A0", VA = "0x113633A0", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x60061A0")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRewardRescueComplete()
    {
    }
  }
}
