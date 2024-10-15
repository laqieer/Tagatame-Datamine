// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildFacilityEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200151F")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Guild/ReqGuildFacilityEnhance", 32741)]
  [FlowNode.Pin(101, "ギルド施設強化完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "ギルド施設強化", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuildFacilityEnhance : FlowNode_Network
  {
    [Token(Token = "0x4004D5B")]
    private const int PIN_INPUT_START_GUILD_FACILITY_ENHANCE = 1;
    [Token(Token = "0x4004D5C")]
    private const int PIN_OUTPUT_END_GUILD_FACILITY_ENHANCE = 101;

    [Token(Token = "0x600578E")]
    [Address(RVA = "0x12D0A90", Offset = "0x12CF890", VA = "0x112D0A90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600578F")]
    [Address(RVA = "0x12D0C40", Offset = "0x12CFA40", VA = "0x112D0C40", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005790")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildFacilityEnhance()
    {
    }

    [Token(Token = "0x2001520")]
    public class Json_ResGuildFacilityEnhance
    {
      [Token(Token = "0x4004D5D")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x4004D5E")]
      [FieldOffset(Offset = "0xC")]
      public JSON_Guild guild;
      [Token(Token = "0x4004D5F")]
      [FieldOffset(Offset = "0x10")]
      public JSON_PlayerGuild player_guild;
      [Token(Token = "0x4004D60")]
      [FieldOffset(Offset = "0x14")]
      public JSON_GuildMember[] applied_member;
      [Token(Token = "0x4004D61")]
      [FieldOffset(Offset = "0x18")]
      public Json_Item[] items;

      [Token(Token = "0x6005791")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuildFacilityEnhance()
      {
      }
    }
  }
}
