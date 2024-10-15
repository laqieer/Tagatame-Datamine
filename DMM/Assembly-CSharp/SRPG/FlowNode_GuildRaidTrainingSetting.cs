// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GuildRaidTrainingSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016C1")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("GuildRaid/Training/GuildRaidTrainingSetting", 32741)]
  [FlowNode.Pin(1, "Set GlobalVars", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Reset GlobalVars", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "Setting Done", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_GuildRaidTrainingSetting : FlowNode
  {
    [Token(Token = "0x4005279")]
    private const int PIN_INPUT_SET = 1;
    [Token(Token = "0x400527A")]
    private const int PIN_INPUT_RESET = 2;
    [Token(Token = "0x400527B")]
    private const int PIN_OUTPUT_SETTING_FINISH = 101;

    [Token(Token = "0x6005D14")]
    [Address(RVA = "0x1319950", Offset = "0x1318750", VA = "0x11319950", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D15")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GuildRaidTrainingSetting()
    {
    }
  }
}
