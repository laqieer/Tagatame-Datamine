// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001514")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "ギルド情報取得完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Guild/ReqGuild", 32741)]
  [FlowNode.Pin(1, "ギルド情報取得", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqGuild : FlowNode_Network
  {
    [Token(Token = "0x4004D3C")]
    private const int PIN_INPUT_START_GUILD = 1;
    [Token(Token = "0x4004D3D")]
    private const int PIN_OUTPUT_END_GUILD = 101;

    [Token(Token = "0x6005775")]
    [Address(RVA = "0x12D3130", Offset = "0x12D1F30", VA = "0x112D3130", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005776")]
    [Address(RVA = "0x12D31E0", Offset = "0x12D1FE0", VA = "0x112D31E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005777")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuild()
    {
    }

    [Token(Token = "0x2001515")]
    public class Json_ResGuild
    {
      [Token(Token = "0x4004D3E")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;
      [Token(Token = "0x4004D3F")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PlayerGuild player_guild;
      [Token(Token = "0x4004D40")]
      [FieldOffset(Offset = "0x10")]
      public JSON_GuildMember[] applied_member;
      [Token(Token = "0x4004D41")]
      [FieldOffset(Offset = "0x14")]
      public int appears_guildraid_period_id;
      [Token(Token = "0x4004D42")]
      [FieldOffset(Offset = "0x18")]
      public int gvg_group_id;
      [Token(Token = "0x4004D43")]
      [FieldOffset(Offset = "0x1C")]
      public int attend_status;
      [Token(Token = "0x4004D44")]
      [FieldOffset(Offset = "0x20")]
      public int is_guild_master_delegated;
      [Token(Token = "0x4004D45")]
      [FieldOffset(Offset = "0x24")]
      public int training_status;

      [Token(Token = "0x6005778")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuild()
      {
      }
    }
  }
}
