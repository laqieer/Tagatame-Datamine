// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TutorialControlUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200188F")]
  [FlowNode.NodeType("Tutorial/ControlUI", 32741)]
  [FlowNode.Pin(1, "Enable", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "Disable", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_TutorialControlUI : FlowNode
  {
    [Token(Token = "0x4005819")]
    private const int PIN_IN_ENABLE = 1;
    [Token(Token = "0x400581A")]
    private const int PIN_IN_DISABLE = 2;
    [Token(Token = "0x400581B")]
    private const int PIN_OUT_OUTPUT = 10;
    [Token(Token = "0x400581C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [BitMask]
    private SceneBattle.eMaskBattleUI ControlType;

    [Token(Token = "0x60062E4")]
    [Address(RVA = "0x316020", Offset = "0x314E20", VA = "0x10316020", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062E5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_TutorialControlUI()
    {
    }
  }
}
