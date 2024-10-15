// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_TipsListCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200186E")]
  [FlowNode.Pin(1, "Tips表示が残っているか確認", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "残っている", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "残りなし", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Tips/TipsListCheck", 32741)]
  public class FlowNode_MP_TipsListCheck : FlowNode
  {
    [Token(Token = "0x40057A4")]
    private const int PIN_IN_IS_CHECK = 1;
    [Token(Token = "0x40057A5")]
    private const int PIN_OUT_YES = 100;
    [Token(Token = "0x40057A6")]
    private const int PIN_OUT_NO = 101;

    [Token(Token = "0x6006279")]
    [Address(RVA = "0x307880", Offset = "0x306680", VA = "0x10307880", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600627A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_TipsListCheck()
    {
    }
  }
}
