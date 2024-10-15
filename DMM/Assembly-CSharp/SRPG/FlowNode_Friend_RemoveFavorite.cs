// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Friend_RemoveFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001672")]
  [FlowNode.NodeType("System/Friend/Favorite/RemoveFavorite", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_Friend_RemoveFavorite : FlowNode_Network
  {
    [Token(Token = "0x40051B6")]
    [FieldOffset(Offset = "0x20")]
    private string mTargetFuid;

    [Token(Token = "0x6005C2D")]
    [Address(RVA = "0x13061C0", Offset = "0x1304FC0", VA = "0x113061C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C2E")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C2F")]
    [Address(RVA = "0x13065C0", Offset = "0x13053C0", VA = "0x113065C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C30")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_Friend_RemoveFavorite()
    {
    }
  }
}
