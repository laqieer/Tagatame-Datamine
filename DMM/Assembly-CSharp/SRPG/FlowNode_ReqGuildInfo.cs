// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGuildInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001521")]
  [FlowNode.NodeType("Guild/ReqGuildInfo", 32741)]
  [FlowNode.Pin(1, "ギルド情報取得", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "ギルド情報取得完了", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGuildInfo : FlowNode_Network
  {
    [Token(Token = "0x4004D62")]
    private const int PIN_INPUT_START_GUILD_INFO = 1;
    [Token(Token = "0x4004D63")]
    private const int PIN_OUTPUT_END_GUILD_INFO = 101;
    [Token(Token = "0x4004D64")]
    [FieldOffset(Offset = "0x20")]
    private long mGuildId;
    [Token(Token = "0x4004D65")]
    [FieldOffset(Offset = "0x28")]
    private GuildData mGuildData;

    [Token(Token = "0x1700094F")]
    public GuildData GuildData
    {
      [Token(Token = "0x6005792"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (GuildData) null;
      }
    }

    [Token(Token = "0x6005793")]
    [Address(RVA = "0x34D360", Offset = "0x34C160", VA = "0x1034D360")]
    public void SetParam(long guild_id)
    {
    }

    [Token(Token = "0x6005794")]
    [Address(RVA = "0x12D12B0", Offset = "0x12D00B0", VA = "0x112D12B0")]
    public void ResetParam()
    {
    }

    [Token(Token = "0x6005795")]
    [Address(RVA = "0x12D0F70", Offset = "0x12CFD70", VA = "0x112D0F70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005796")]
    [Address(RVA = "0x12D1060", Offset = "0x12CFE60", VA = "0x112D1060", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005797")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGuildInfo()
    {
    }

    [Token(Token = "0x2001522")]
    public class Json_ResGuildInfo
    {
      [Token(Token = "0x4004D66")]
      [FieldOffset(Offset = "0x8")]
      public JSON_Guild guild_recommend;

      [Token(Token = "0x6005798")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ResGuildInfo()
      {
      }
    }
  }
}
