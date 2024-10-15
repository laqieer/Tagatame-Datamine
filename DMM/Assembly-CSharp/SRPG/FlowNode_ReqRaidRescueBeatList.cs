// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRescueBeatList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001829")]
  [FlowNode.NodeType("Raid/Req/Rescue/BeatList", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidRescueBeatList : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x6006185")]
    [Address(RVA = "0x1361BB0", Offset = "0x13609B0", VA = "0x11361BB0", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006186")]
    [Address(RVA = "0x1361C40", Offset = "0x1360A40", VA = "0x11361C40", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x6006187")]
    [Address(RVA = "0x1361B40", Offset = "0x1360940", VA = "0x11361B40")]
    private IEnumerator DownloadUnitImage() => (IEnumerator) null;

    [Token(Token = "0x6006188")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRescueBeatList()
    {
    }
  }
}
