// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GuildRaidCheckTrainingFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016BB")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GuildRaid/Training/Check", 32741)]
  [FlowNode.Pin(1, "練習モード用GlobalVars確認", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "GlobalVarが有効", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "GlobalVarが無効", FlowNode.PinTypes.Output, 12)]
  public class FlowNode_GuildRaidCheckTrainingFlag : FlowNode
  {
    [Token(Token = "0x4005271")]
    private const int PIN_INPUT_CHECK = 1;
    [Token(Token = "0x4005272")]
    private const int PIN_OUTPUT_TRUE = 11;
    [Token(Token = "0x4005273")]
    private const int PIN_OUTPUT_FALSE = 12;

    [Token(Token = "0x6005D08")]
    [Address(RVA = "0x13198C0", Offset = "0x13186C0", VA = "0x113198C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D09")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GuildRaidCheckTrainingFlag()
    {
    }
  }
}
