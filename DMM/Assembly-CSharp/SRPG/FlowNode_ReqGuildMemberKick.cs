// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildMemberKick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001525")]
  [FlowNode.Pin(101, "ギルドメンバー追放完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "ギルドメンバー追放", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Guild/ReqGuildMemberKick", 32741)]
  public class FlowNode_ReqGuildMemberKick : FlowNode_Network
  {
    [Token(Token = "0x4004D6C")]
    private const int PIN_INPUT_START_GUILD_MEMBER_KICK = 1;
    [Token(Token = "0x4004D6D")]
    private const int PIN_OUTPUT_END_GUILD_MEMBER_KICK = 101;

    [Token(Token = "0x600579F")]
    [Address(RVA = "0x12D1A30", Offset = "0x12D0830", VA = "0x112D1A30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057A0")]
    [Address(RVA = "0x12D1B50", Offset = "0x12D0950", VA = "0x112D1B50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057A1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildMemberKick()
    {
    }

    [Token(Token = "0x2001526")]
    public class Json_ResGuildMemberKick
    {
      [Token(Token = "0x4004D6E")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;

      [Token(Token = "0x60057A2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuildMemberKick()
      {
      }
    }
  }
}
