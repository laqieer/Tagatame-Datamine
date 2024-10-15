// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildRequestEntryApproval
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001529")]
  [AddComponentMenu("")]
  [FlowNode.Pin(102, "ギルド加入申請を拒否完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "ギルド加入申請を承認完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(103, "ギルド加入申請を一括拒否完了", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(2, "ギルド加入申請を拒否", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "ギルド加入申請を承認", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Guild/ReqGuildRequestEntryApproval", 32741)]
  [FlowNode.Pin(3, "ギルド加入申請を一括拒否", FlowNode.PinTypes.Input, 2)]
  public class FlowNode_ReqGuildRequestEntryApproval : FlowNode_Network
  {
    [Token(Token = "0x4004D74")]
    private const int PIN_INPUT_START_GUILD_REQUEST_ENTRY_APPROVAL_OK = 1;
    [Token(Token = "0x4004D75")]
    private const int PIN_INPUT_START_GUILD_REQUEST_ENTRY_APPROVAL_NG = 2;
    [Token(Token = "0x4004D76")]
    private const int PIN_INPUT_START_GUILD_REQUEST_ENTRY_APPROVAL_NG_ALL = 3;
    [Token(Token = "0x4004D77")]
    private const int PIN_OUTPUT_END_GUILD_REQUEST_ENTRY_APPROVAL_OK = 101;
    [Token(Token = "0x4004D78")]
    private const int PIN_OUTPUT_END_GUILD_REQUEST_ENTRY_APPROVAL_NG = 102;
    [Token(Token = "0x4004D79")]
    private const int PIN_OUTPUT_END_GUILD_REQUEST_ENTRY_APPROVAL_NG_ALL = 103;
    [Token(Token = "0x4004D7A")]
    [FieldOffset(Offset = "0x20")]
    private int mPinId;

    [Token(Token = "0x60057A7")]
    [Address(RVA = "0x12D1DD0", Offset = "0x12D0BD0", VA = "0x112D1DD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057A8")]
    [Address(RVA = "0x12D29E0", Offset = "0x12D17E0", VA = "0x112D29E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057A9")]
    [Address(RVA = "0x12D2690", Offset = "0x12D1490", VA = "0x112D2690")]
    private void OnSuccess_ApprovalOK(WWWResult www)
    {
    }

    [Token(Token = "0x60057AA")]
    [Address(RVA = "0x12D23B0", Offset = "0x12D11B0", VA = "0x112D23B0")]
    private void OnSuccess_ApprovalNG(WWWResult www)
    {
    }

    [Token(Token = "0x60057AB")]
    [Address(RVA = "0x12D20F0", Offset = "0x12D0EF0", VA = "0x112D20F0")]
    private void OnSuccess_ApprovalNGAll(WWWResult www)
    {
    }

    [Token(Token = "0x60057AC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildRequestEntryApproval()
    {
    }

    [Token(Token = "0x200152A")]
    public class Json_ResGuild
    {
      [Token(Token = "0x4004D7B")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild;
      [Token(Token = "0x4004D7C")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GuildMember[] applied_member;

      [Token(Token = "0x60057AD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuild()
      {
      }
    }
  }
}
