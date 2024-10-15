// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001832")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Raid/Req/Select", 32741)]
  public class FlowNode_ReqRaidSelect : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x60061A4")]
    [Address(RVA = "0x1363890", Offset = "0x1362690", VA = "0x11363890", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x60061A5")]
    [Address(RVA = "0x1363920", Offset = "0x1362720", VA = "0x11363920", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x60061A6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidSelect()
    {
    }
  }
}
