// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001822")]
  [FlowNode.NodeType("Raid/Req/Info", 32741)]
  [FlowNode.Pin(201, "TimeOut", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "Already Beat", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(203, "Rescue Damage Zero", FlowNode.PinTypes.Output, 203)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidInfo : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x6006168")]
    [Address(RVA = "0x13603E0", Offset = "0x135F1E0", VA = "0x113603E0", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006169")]
    [Address(RVA = "0x1360840", Offset = "0x135F640", VA = "0x11360840", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x600616A")]
    [Address(RVA = "0x1360370", Offset = "0x135F170", VA = "0x11360370")]
    private IEnumerator DownloadUnitImage() => (IEnumerator) null;

    [Token(Token = "0x600616B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidInfo()
    {
    }
  }
}
