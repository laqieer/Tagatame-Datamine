// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildChangeRole
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001518")]
  [FlowNode.Pin(101, "ギルドメンバー役職変更完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.NodeType("Guild/ReqGuildMasterChange", 32741)]
  [FlowNode.Pin(1, "ギルドメンバー役職変更", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildChangeRole : FlowNode_Network
  {
    [Token(Token = "0x4004D4A")]
    private const int PIN_INPUT_START_GUILD_CHANGE_ROLE = 1;
    [Token(Token = "0x4004D4B")]
    private const int PIN_OUTPUT_END_GUILD_CHANGE_ROLE = 101;

    [Token(Token = "0x600577D")]
    [Address(RVA = "0x12CFA00", Offset = "0x12CE800", VA = "0x112CFA00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600577E")]
    [Address(RVA = "0x12CFD10", Offset = "0x12CEB10", VA = "0x112CFD10")]
    private void RequestChangeRole()
    {
    }

    [Token(Token = "0x600577F")]
    [Address(RVA = "0x12CFA30", Offset = "0x12CE830", VA = "0x112CFA30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005780")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildChangeRole()
    {
    }

    [Token(Token = "0x2001519")]
    public class Json_ResGuildChangeRole
    {
      [Token(Token = "0x4004D4C")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;
      [Token(Token = "0x4004D4D")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PlayerGuild player_guild;
      [Token(Token = "0x4004D4E")]
      [FieldOffset(Offset = "0x10")]
      public JSON_GuildMember[] applied_member;

      [Token(Token = "0x6005781")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuildChangeRole()
      {
      }
    }
  }
}
