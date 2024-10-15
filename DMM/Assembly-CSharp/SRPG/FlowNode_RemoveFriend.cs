// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RemoveFriend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200147C")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Friend/RemoveFriend", 32741)]
  [FlowNode.Pin(10, "ひとりフレンド解除", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "ひとりフレンド解除成功", FlowNode.PinTypes.Output, 20)]
  public class FlowNode_RemoveFriend : FlowNode_Network
  {
    [Token(Token = "0x6005595")]
    [Address(RVA = "0x12B4070", Offset = "0x12B2E70", VA = "0x112B4070", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005596")]
    [Address(RVA = "0x12B4230", Offset = "0x12B3030", VA = "0x112B4230", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005597")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_RemoveFriend()
    {
    }
  }
}
