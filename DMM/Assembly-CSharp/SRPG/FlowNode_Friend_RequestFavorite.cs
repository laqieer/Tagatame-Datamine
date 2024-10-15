// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Friend_RequestFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001675")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("System/Friend/Favorite/RequestFavorite", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_Friend_RequestFavorite : FlowNode_Network
  {
    [Token(Token = "0x40051BA")]
    [FieldOffset(Offset = "0x20")]
    private string mTargetFuid;

    [Token(Token = "0x6005C37")]
    [Address(RVA = "0x13068C0", Offset = "0x13056C0", VA = "0x113068C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C38")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005C39")]
    [Address(RVA = "0x1306CC0", Offset = "0x1305AC0", VA = "0x11306CC0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005C3A")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_Friend_RequestFavorite()
    {
    }
  }
}
