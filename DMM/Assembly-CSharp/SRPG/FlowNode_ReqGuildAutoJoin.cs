// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildAutoJoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001516")]
  [FlowNode.NodeType("Guild/ReqGuildAutoJoin", 32741)]
  [FlowNode.Pin(1, "自動ギルド加入", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "自動ギルド加入完了", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqGuildAutoJoin : FlowNode_Network
  {
    [Token(Token = "0x4004D46")]
    private const int PIN_INPUT_START_GUILD_AUTO_JOIN = 1;
    [Token(Token = "0x4004D47")]
    private const int PIN_OUTPUT_END_GUILD_AUTO_JOIN = 101;

    [Token(Token = "0x6005779")]
    [Address(RVA = "0x12CF700", Offset = "0x12CE500", VA = "0x112CF700", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600577A")]
    [Address(RVA = "0x12CF7B0", Offset = "0x12CE5B0", VA = "0x112CF7B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600577B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildAutoJoin()
    {
    }

    [Token(Token = "0x2001517")]
    public class Json_ReqGuildAutoJoin
    {
      [Token(Token = "0x4004D48")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;
      [Token(Token = "0x4004D49")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PlayerGuild player_guild;

      [Token(Token = "0x600577C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ReqGuildAutoJoin()
      {
      }
    }
  }
}
