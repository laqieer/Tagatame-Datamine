// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildLeave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001523")]
  [FlowNode.NodeType("Guild/ReqGuildLeave", 32741)]
  [FlowNode.Pin(1, "ギルド脱退", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "ギルド脱退完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "ギルド脱退失敗", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildLeave : FlowNode_Network
  {
    [Token(Token = "0x4004D67")]
    private const int PIN_INPUT_START_GUILD_LEAVE = 1;
    [Token(Token = "0x4004D68")]
    private const int PIN_OUTPUT_END_GUILD_LEAVE = 101;
    [Token(Token = "0x4004D69")]
    private const int PIN_OUTPUT_ERROR_GUILD_LEAVE = 102;

    [Token(Token = "0x6005799")]
    [Address(RVA = "0x12D15D0", Offset = "0x12D03D0", VA = "0x112D15D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600579A")]
    [Address(RVA = "0x12D1600", Offset = "0x12D0400", VA = "0x112D1600", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600579B")]
    [Address(RVA = "0x12D12E0", Offset = "0x12D00E0", VA = "0x112D12E0")]
    private void LeaveGuild()
    {
    }

    [Token(Token = "0x600579C")]
    [Address(RVA = "0x126D300", Offset = "0x126C100", VA = "0x1126D300")]
    private void BackHome(GameObject go)
    {
    }

    [Token(Token = "0x600579D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildLeave()
    {
    }

    [Token(Token = "0x2001524")]
    public class Json_ResGuildLeave
    {
      [Token(Token = "0x4004D6A")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;
      [Token(Token = "0x4004D6B")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PlayerGuild player_guild;

      [Token(Token = "0x600579E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuildLeave()
      {
      }
    }
  }
}
