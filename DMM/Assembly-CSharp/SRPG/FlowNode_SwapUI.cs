// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SwapUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001645")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UI/Swap", 32741)]
  [FlowNode.Pin(1, "Swap In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "Swap Out", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_SwapUI : FlowNode
  {
    [Token(Token = "0x40050DF")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.ShowInInfo]
    public GameObject Target;
    [Token(Token = "0x40050E0")]
    [FieldOffset(Offset = "0x1C")]
    public bool Deactivate;
    [Token(Token = "0x40050E1")]
    [FieldOffset(Offset = "0x20")]
    private GameObject mDummy;
    [Token(Token = "0x40050E2")]
    [FieldOffset(Offset = "0x24")]
    private DestroyEventListener mTargetDestroyEvent;
    [Token(Token = "0x40050E3")]
    [FieldOffset(Offset = "0x28")]
    private DestroyEventListener mDummyDestroyEvent;

    [Token(Token = "0x6005B8C")]
    [Address(RVA = "0x130F0E0", Offset = "0x130DEE0", VA = "0x1130F0E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B8D")]
    [Address(RVA = "0x130F130", Offset = "0x130DF30", VA = "0x1130F130")]
    private void SwapIn()
    {
    }

    [Token(Token = "0x6005B8E")]
    [Address(RVA = "0x130F2D0", Offset = "0x130E0D0", VA = "0x1130F2D0")]
    private void SwapOut()
    {
    }

    [Token(Token = "0x6005B8F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SwapUI()
    {
    }
  }
}
