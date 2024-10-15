// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArtifactSell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001490")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("System/ReqArtifact/ReqArtifactSell", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_ReqArtifactSell : FlowNode_Network
  {
    [Token(Token = "0x60055DE")]
    [Address(RVA = "0x12B7E40", Offset = "0x12B6C40", VA = "0x112B7E40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055DF")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60055E0")]
    [Address(RVA = "0x12B7FD0", Offset = "0x12B6DD0", VA = "0x112B7FD0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055E1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArtifactSell()
    {
    }
  }
}
