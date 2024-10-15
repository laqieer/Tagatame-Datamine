// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRescue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001828")]
  [FlowNode.NodeType("Raid/Req/Rescue/Index", 32741)]
  [FlowNode.Pin(204, "Rescue Player Level Short", FlowNode.PinTypes.Output, 204)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidRescue : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x6006181")]
    [Address(RVA = "0x1362280", Offset = "0x1361080", VA = "0x11362280", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006182")]
    [Address(RVA = "0x1362310", Offset = "0x1361110", VA = "0x11362310", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x6006183")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRescue()
    {
    }
  }
}
