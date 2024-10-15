// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GuildRaidMockWarSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016BD")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Set", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(900, "Error", FlowNode.PinTypes.Output, 900)]
  [FlowNode.Pin(2, "Set Mock War", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Set Main War", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("GuildRaid/MockWarSetting", 32741)]
  [FlowNode.Pin(3, "Set Trial War", FlowNode.PinTypes.Input, 3)]
  public class Flownode_GuildRaidMockWarSetting : FlowNode
  {
    [Token(Token = "0x4005274")]
    public const int PIN_INPUT_SET_MAIN = 1;
    [Token(Token = "0x4005275")]
    public const int PIN_INPUT_SET_MOCK = 2;
    [Token(Token = "0x4005276")]
    public const int PIN_INPUT_SET_TRIAL = 3;
    [Token(Token = "0x4005277")]
    public const int PIN_OUTPUT_SET_FINISH = 101;
    [Token(Token = "0x4005278")]
    public const int PIN_OUTPUT_ERROR = 900;

    [Token(Token = "0x6005D0C")]
    [Address(RVA = "0x132DF90", Offset = "0x132CD90", VA = "0x1132DF90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005D0D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GuildRaidMockWarSetting()
    {
    }
  }
}
