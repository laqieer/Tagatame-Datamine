// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRewardAreaClear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200182E")]
  [FlowNode.NodeType("Raid/Req/Reward/AreaClear", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidRewardAreaClear : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x6006198")]
    [Address(RVA = "0x1362A40", Offset = "0x1361840", VA = "0x11362A40", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006199")]
    [Address(RVA = "0x1362B40", Offset = "0x1361940", VA = "0x11362B40", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x600619A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRewardAreaClear()
    {
    }
  }
}
