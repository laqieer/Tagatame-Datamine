// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ResetArenaReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015ED")]
  [AddComponentMenu("")]
  [FlowNode.Pin(10000, "完了", FlowNode.PinTypes.Output, 10000)]
  [FlowNode.NodeType("System/ResetArenaReward", 32741)]
  [FlowNode.Pin(0, "実行", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_ResetArenaReward : FlowNode
  {
    [Token(Token = "0x4004F93")]
    private const int PIN_IN_EXEC = 0;
    [Token(Token = "0x4004F94")]
    private const int PIN_OUT_EXEC = 10000;

    [Token(Token = "0x6005A17")]
    [Address(RVA = "0x12EB1F0", Offset = "0x12E9FF0", VA = "0x112EB1F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005A18")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ResetArenaReward()
    {
    }
  }
}
