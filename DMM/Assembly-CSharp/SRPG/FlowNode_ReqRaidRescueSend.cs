// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRescueSend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200182C")]
  [FlowNode.NodeType("Raid/Req/Rescue/Send", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidRescueSend : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x6006192")]
    [Address(RVA = "0x13620D0", Offset = "0x1360ED0", VA = "0x113620D0", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006193")]
    [Address(RVA = "0x1362230", Offset = "0x1361030", VA = "0x11362230", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x6006194")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRescueSend()
    {
    }
  }
}
