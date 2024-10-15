// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ChangeSceneByNetwork
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001376")]
  [FlowNode.NodeType("Network/ChangeSceneByNetwork", 32741)]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "なにもしない", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(12, "強制的にシーンを再読み込み", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(11, "強制的にホームに遷移", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_ChangeSceneByNetwork : FlowNode
  {
    [Token(Token = "0x40047DA")]
    private const int PIN_IN_INPUT = 0;
    [Token(Token = "0x40047DB")]
    private const int PIN_OUT_DO_NOTHING = 10;
    [Token(Token = "0x40047DC")]
    private const int PIN_OUT_GO_TO_HOME = 11;
    [Token(Token = "0x40047DD")]
    private const int PIN_OUT_RELOAD_SCENE = 12;

    [Token(Token = "0x60051AE")]
    [Address(RVA = "0x126AFA0", Offset = "0x1269DA0", VA = "0x1126AFA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051AF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ChangeSceneByNetwork()
    {
    }
  }
}
