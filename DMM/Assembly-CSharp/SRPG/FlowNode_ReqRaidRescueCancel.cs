// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidRescueCancel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200182B")]
  [FlowNode.NodeType("Raid/Req/Rescue/Cancel", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqRaidRescueCancel : FlowNode_ReqRaidBase
  {
    [Token(Token = "0x600618F")]
    [Address(RVA = "0x1361FE0", Offset = "0x1360DE0", VA = "0x11361FE0", Slot = "23")]
    public override WebAPI GenerateWebAPI() => (WebAPI) null;

    [Token(Token = "0x6006190")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "24")]
    public override bool Success(WWWResult www) => new bool();

    [Token(Token = "0x6006191")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidRescueCancel()
    {
    }
  }
}
