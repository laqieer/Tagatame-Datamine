// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqQuestRankingParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Text;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001578")]
  [FlowNode.NodeType("System/ReqQuest/ReqQuestRankingParty")]
  [FlowNode.Pin(100, "指定ユーザのパーティ取得", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "指定ユーザのパーティ取得(成功)", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "指定ユーザのパーティ取得(失敗)", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class FlowNode_ReqQuestRankingParty : FlowNode_Network
  {
    [Token(Token = "0x4004E2F")]
    public const int INPUT_RANKING_PARTY = 100;
    [Token(Token = "0x4004E30")]
    public const int OUTPUT_RANKING_PARTY_SUCCESS = 101;
    [Token(Token = "0x4004E31")]
    public const int OUTPUT_RANKING_PARTY_FAILED = 102;

    [Token(Token = "0x60058A9")]
    [Address(RVA = "0x12D8130", Offset = "0x12D6F30", VA = "0x112D8130", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058AA")]
    [Address(RVA = "0x3161D0", Offset = "0x314FD0", VA = "0x103161D0")]
    private void Success()
    {
    }

    [Token(Token = "0x60058AB")]
    [Address(RVA = "0x12D8220", Offset = "0x12D7020", VA = "0x112D8220", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058AC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqQuestRankingParty()
    {
    }

    [Token(Token = "0x2001579")]
    public class API_ReqQuestRankingParty : WebAPI
    {
      [Token(Token = "0x60058AD")]
      [Address(RVA = "0x12C8A80", Offset = "0x12C7880", VA = "0x112C8A80")]
      public API_ReqQuestRankingParty(
        int schedule_id,
        RankingQuestType type,
        string quest_id,
        string uid,
        Network.ResponseCallback response)
      {
      }

      [Token(Token = "0x60058AE")]
      [Address(RVA = "0x12C8990", Offset = "0x12C7790", VA = "0x112C8990")]
      private static void AppendKeyValue(StringBuilder sb, string key, int value)
      {
      }

      [Token(Token = "0x60058AF")]
      [Address(RVA = "0x12C8A00", Offset = "0x12C7800", VA = "0x112C8A00")]
      private static void AppendKeyValue(StringBuilder sb, string key, string value)
      {
      }
    }

    [Token(Token = "0x200157A")]
    [Serializable]
    public class Json_LightItem
    {
      [Token(Token = "0x4004E32")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4004E33")]
      [FieldOffset(Offset = "0xC")]
      public int num;

      [Token(Token = "0x60058B0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_LightItem()
      {
      }
    }

    [Token(Token = "0x200157B")]
    [Serializable]
    public class Json_Party
    {
      [Token(Token = "0x4004E34")]
      [FieldOffset(Offset = "0x8")]
      public string uid;
      [Token(Token = "0x4004E35")]
      [FieldOffset(Offset = "0xC")]
      public string fuid;
      [Token(Token = "0x4004E36")]
      [FieldOffset(Offset = "0x10")]
      public string name;
      [Token(Token = "0x4004E37")]
      [FieldOffset(Offset = "0x14")]
      public string award;
      [Token(Token = "0x4004E38")]
      [FieldOffset(Offset = "0x18")]
      public int lv;
      [Token(Token = "0x4004E39")]
      [FieldOffset(Offset = "0x20")]
      public long lastlogin;
      [Token(Token = "0x4004E3A")]
      [FieldOffset(Offset = "0x28")]
      public bool is_multi_push;
      [Token(Token = "0x4004E3B")]
      [FieldOffset(Offset = "0x2C")]
      public string multi_comment;
      [Token(Token = "0x4004E3C")]
      [FieldOffset(Offset = "0x30")]
      public string created_at;
      [Token(Token = "0x4004E3D")]
      [FieldOffset(Offset = "0x34")]
      public Json_Unit[] units;
      [Token(Token = "0x4004E3E")]
      [FieldOffset(Offset = "0x38")]
      public Json_Support help;
      [Token(Token = "0x4004E3F")]
      [FieldOffset(Offset = "0x3C")]
      public FlowNode_ReqQuestRankingParty.Json_LightItem[] items;

      [Token(Token = "0x60058B1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Party()
      {
      }
    }

    [Token(Token = "0x200157C")]
    [Serializable]
    public class Json
    {
      [Token(Token = "0x4004E40")]
      [FieldOffset(Offset = "0x8")]
      public Json_Unit[] party;
      [Token(Token = "0x4004E41")]
      [FieldOffset(Offset = "0xC")]
      public Json_Support help;
      [Token(Token = "0x4004E42")]
      [FieldOffset(Offset = "0x10")]
      public FlowNode_ReqQuestRankingParty.Json_LightItem[] items;
      [Token(Token = "0x4004E43")]
      [FieldOffset(Offset = "0x14")]
      public JSON_PlayerBuff player_buff;

      [Token(Token = "0x60058B2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json()
      {
      }
    }
  }
}
