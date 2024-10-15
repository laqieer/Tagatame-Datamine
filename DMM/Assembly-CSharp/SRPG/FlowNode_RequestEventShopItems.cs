// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RequestEventShopItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015C5")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(11, "Period", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("System/Shop/RequestEventShopItems", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_RequestEventShopItems : FlowNode_Network
  {
    [Token(Token = "0x4004F2D")]
    public const string ErrorWindowPrefabPath = "e/UI/NetworkErrorWindowEx";

    [Token(Token = "0x600598B")]
    [Address(RVA = "0x12E8E50", Offset = "0x12E7C50", VA = "0x112E8E50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600598C")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600598D")]
    [Address(RVA = "0x12E9550", Offset = "0x12E8350", VA = "0x112E9550")]
    private void Period()
    {
    }

    [Token(Token = "0x600598E")]
    [Address(RVA = "0x12E9090", Offset = "0x12E7E90", VA = "0x112E9090")]
    private void OnPeriod()
    {
    }

    [Token(Token = "0x600598F")]
    [Address(RVA = "0x12E91D0", Offset = "0x12E7FD0", VA = "0x112E91D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005990")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_RequestEventShopItems()
    {
    }
  }
}
