// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRequestEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001527")]
  [FlowNode.NodeType("Guild/ReqGuildRequestEntry", 32741)]
  [FlowNode.Pin(1, "ギルド加入申請", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "ギルド加入申請完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "ギルド加入申請_自動承認", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildRequestEntry : FlowNode_Network
  {
    [Token(Token = "0x4004D6F")]
    private const int PIN_INPUT_START_GUILD_REQUEST_ENTRY = 1;
    [Token(Token = "0x4004D70")]
    private const int PIN_OUTPUT_END_GUILD_REQUEST_ENTRY = 101;
    [Token(Token = "0x4004D71")]
    private const int PIN_OUTPUT_END_GUILD_REQUEST_ENTRY_AND_JOIN = 102;

    [Token(Token = "0x60057A3")]
    [Address(RVA = "0x12D2A60", Offset = "0x12D1860", VA = "0x112D2A60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057A4")]
    [Address(RVA = "0x12D2B80", Offset = "0x12D1980", VA = "0x112D2B80", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057A5")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRequestEntry()
    {
    }

    [Token(Token = "0x2001528")]
    public class Json_ResGuildRequestEntry
    {
      [Token(Token = "0x4004D72")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;
      [Token(Token = "0x4004D73")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PlayerGuild player_guild;

      [Token(Token = "0x60057A6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuildRequestEntry()
      {
      }
    }
  }
}
