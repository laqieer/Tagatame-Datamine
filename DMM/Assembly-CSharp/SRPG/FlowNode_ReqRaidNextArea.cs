// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidNextArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001824")]
  [FlowNode.NodeType("Raid/Req/NextArea", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidNextArea : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x6006175")]
    [Address(RVA = "0x1360FE0", Offset = "0x135FDE0", VA = "0x11360FE0", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006176")]
    [Address(RVA = "0x1361070", Offset = "0x135FE70", VA = "0x11361070", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x6006177")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidNextArea()
    {
    }
  }
}
