// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_Versus_GradientFade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017F6")]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "Finish", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(2, "Fade Out", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Fade In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("MultiPlay/Versus/GradientFade", 32741)]
  public class FlowNode_MP_Versus_GradientFade : FlowNode
  {
    [Token(Token = "0x400564D")]
    private const int PIN_IN_FADE_IN = 1;
    [Token(Token = "0x400564E")]
    private const int PIN_IN_FADE_OUT = 2;
    [Token(Token = "0x400564F")]
    private const int PIN_OUT_FINISH = 11;
    [Token(Token = "0x4005650")]
    [FieldOffset(Offset = "0x18")]
    private bool mFading;

    [Token(Token = "0x60060E8")]
    [Address(RVA = "0x135AF80", Offset = "0x1359D80", VA = "0x1135AF80", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60060E9")]
    [Address(RVA = "0x135B050", Offset = "0x1359E50", VA = "0x1135B050")]
    private void Update()
    {
    }

    [Token(Token = "0x60060EA")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_Versus_GradientFade()
    {
    }
  }
}
