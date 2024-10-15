// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_NetworkIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200143D")]
  [FlowNode.NodeType("Network/NetworkIndicator", 32741)]
  [FlowNode.Pin(0, "Destroy", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(5, "Create", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "OnDestroy", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(20, "OnCreate", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  public class FlowNode_NetworkIndicator : FlowNode
  {
    [Token(Token = "0x4004AEA")]
    [FieldOffset(Offset = "0x18")]
    private FlowNode_NetworkIndicator.NetworkIndicator mRef;

    [Token(Token = "0x600549B")]
    [Address(RVA = "0x1290F20", Offset = "0x128FD20", VA = "0x11290F20")]
    public static bool NeedDisplay() => new bool();

    [Token(Token = "0x600549C")]
    [Address(RVA = "0x1291080", Offset = "0x128FE80", VA = "0x11291080", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600549D")]
    [Address(RVA = "0x1290FB0", Offset = "0x128FDB0", VA = "0x11290FB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600549E")]
    [Address(RVA = "0x12910B0", Offset = "0x128FEB0", VA = "0x112910B0")]
    public FlowNode_NetworkIndicator()
    {
    }

    [Token(Token = "0x200143E")]
    private class NetworkIndicator
    {
      [Token(Token = "0x4004AEB")]
      [FieldOffset(Offset = "0x0")]
      private static List<FlowNode_NetworkIndicator.NetworkIndicator> mInstances;
      [Token(Token = "0x4004AEC")]
      [FieldOffset(Offset = "0x8")]
      private bool mActive;

      [Token(Token = "0x600549F")]
      [Address(RVA = "0x129FFC0", Offset = "0x129EDC0", VA = "0x1129FFC0")]
      public static bool NeedDisplay() => new bool();

      [Token(Token = "0x60054A0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public NetworkIndicator()
      {
      }

      [Token(Token = "0x60054A1")]
      [Address(RVA = "0x129FF20", Offset = "0x129ED20", VA = "0x1129FF20", Slot = "1")]
      ~NetworkIndicator()
      {
      }

      [Token(Token = "0x60054A2")]
      [Address(RVA = "0x129FEA0", Offset = "0x129ECA0", VA = "0x1129FEA0")]
      public void Enable()
      {
      }

      [Token(Token = "0x60054A3")]
      [Address(RVA = "0x129FE20", Offset = "0x129EC20", VA = "0x1129FE20")]
      public void Disable()
      {
      }

      [Token(Token = "0x60054A4")]
      [Address(RVA = "0x12A0020", Offset = "0x129EE20", VA = "0x112A0020")]
      static NetworkIndicator()
      {
      }
    }
  }
}
