// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsTutorialSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200188C")]
  [AddComponentMenu("")]
  [FlowNode.Pin(120, "Failed", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(112, "IsTutorialSkipEnd", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(111, "IsTutorialEnd", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(101, "IsTutorialSkipping", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("FlowNode_IsTutorialSkip", 32741)]
  [FlowNode.Pin(110, "IsNotTutorialSkip", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "IsTutorialSkip", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_IsTutorialSkip : FlowNode
  {
    [Token(Token = "0x400580D")]
    private const int PIN_IN = 1;
    [Token(Token = "0x400580E")]
    private const int PIN_OUT_IS_CAN_TUTORIAL_SKIP = 100;
    [Token(Token = "0x400580F")]
    private const int PIN_OUT_IS_TUTORIAL_SKIPPING = 101;
    [Token(Token = "0x4005810")]
    private const int PIN_OUT_IS_NOT_TUTORIAL_SKIP = 110;
    [Token(Token = "0x4005811")]
    private const int PIN_OUT_IS_TUTORIAL_END = 111;
    [Token(Token = "0x4005812")]
    private const int PIN_OUT_IS_TUTORIAL_SKIP_END = 112;
    [Token(Token = "0x4005813")]
    private const int PIN_OUT_FAILED = 120;

    [Token(Token = "0x60062D9")]
    [Address(RVA = "0x307520", Offset = "0x306320", VA = "0x10307520", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062DA")]
    [Address(RVA = "0x307190", Offset = "0x305F90", VA = "0x10307190")]
    private bool IsDownloadedAssets() => new bool();

    [Token(Token = "0x60062DB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsTutorialSkip()
    {
    }
  }
}
