// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqQuestRanking
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
  [Token(Token = "0x2001570")]
  [AddComponentMenu("")]
  [FlowNode.Pin(200, "ランキング取得(自身)", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(300, "ランキング取得(成功)", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(301, "ランキング取得(失敗)", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(50, "ランキング取得(TOP + 自身)", FlowNode.PinTypes.Input, 50)]
  [FlowNode.NodeType("System/ReqQuest/ReqQuestRanking")]
  [FlowNode.Pin(100, "ランキング取得(TOP)", FlowNode.PinTypes.Input, 100)]
  public class FlowNode_ReqQuestRanking : FlowNode_Network
  {
    [Token(Token = "0x4004E07")]
    public const int INPUT_REQUEST_RANKING_TOP_OWN = 50;
    [Token(Token = "0x4004E08")]
    public const int INPUT_REQUEST_RANKING_TOP = 100;
    [Token(Token = "0x4004E09")]
    public const int INPUT_REQUEST_RANKING_OWN = 200;
    [Token(Token = "0x4004E0A")]
    public const int OUTPUT_REQUEST_RANKING_SUCCESS = 300;
    [Token(Token = "0x4004E0B")]
    public const int OUTPUT_REQUEST_RANKING_FAILED = 301;
    [Token(Token = "0x4004E0C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RankingQuestRankWindow m_TargetWindow;

    [Token(Token = "0x600588D")]
    [Address(RVA = "0x12D8830", Offset = "0x12D7630", VA = "0x112D8830", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600588E")]
    [Address(RVA = "0x1297AE0", Offset = "0x12968E0", VA = "0x11297AE0")]
    private void Success()
    {
    }

    [Token(Token = "0x600588F")]
    [Address(RVA = "0x12D8CA0", Offset = "0x12D7AA0", VA = "0x112D8CA0")]
    private void ResponseCallback_RequestRankingTopOwn(WWWResult www)
    {
    }

    [Token(Token = "0x6005890")]
    [Address(RVA = "0x12D8FC0", Offset = "0x12D7DC0", VA = "0x112D8FC0")]
    private void ResponseCallback_RequestRankingTop(WWWResult www)
    {
    }

    [Token(Token = "0x6005891")]
    [Address(RVA = "0x12D8A30", Offset = "0x12D7830", VA = "0x112D8A30")]
    private void ResponseCallback_RequestRankingOwn(WWWResult www)
    {
    }

    [Token(Token = "0x6005892")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005893")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqQuestRanking()
    {
    }

    [Token(Token = "0x2001571")]
    public class API_ReqQuestRanking : WebAPI
    {
      [Token(Token = "0x6005894")]
      [Address(RVA = "0x12C8E20", Offset = "0x12C7C20", VA = "0x112C8E20")]
      public API_ReqQuestRanking(
        int schedule_id,
        RankingQuestType type,
        string quest_id,
        int rank,
        bool isOwn,
        Network.ResponseCallback response)
      {
      }

      [Token(Token = "0x6005895")]
      [Address(RVA = "0x12C8DB0", Offset = "0x12C7BB0", VA = "0x112C8DB0")]
      private static void AppendKeyValue(StringBuilder sb, string key, int value)
      {
      }

      [Token(Token = "0x6005896")]
      [Address(RVA = "0x12C8D30", Offset = "0x12C7B30", VA = "0x112C8D30")]
      private static void AppendKeyValue(StringBuilder sb, string key, string value)
      {
      }
    }

    [Token(Token = "0x2001572")]
    [Serializable]
    public class Json_UnitDataLight
    {
      [Token(Token = "0x4004E0D")]
      [FieldOffset(Offset = "0x8")]
      public string unit_iname;
      [Token(Token = "0x4004E0E")]
      [FieldOffset(Offset = "0xC")]
      public int unit_lv;
      [Token(Token = "0x4004E0F")]
      [FieldOffset(Offset = "0x10")]
      public int job_lv;

      [Token(Token = "0x6005897")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_UnitDataLight()
      {
      }
    }

    [Token(Token = "0x2001573")]
    [Serializable]
    public class Json_OwnRankingData
    {
      [Token(Token = "0x4004E10")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_ReqQuestRanking.Json_UnitDataLight unit;
      [Token(Token = "0x4004E11")]
      [FieldOffset(Offset = "0xC")]
      public int rank;
      [Token(Token = "0x4004E12")]
      [FieldOffset(Offset = "0x10")]
      public int main_score;
      [Token(Token = "0x4004E13")]
      [FieldOffset(Offset = "0x14")]
      public int sub_score;

      [Token(Token = "0x6005898")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_OwnRankingData()
      {
      }
    }

    [Token(Token = "0x2001574")]
    [Serializable]
    public class Json_OthersRankingData
    {
      [Token(Token = "0x4004E14")]
      [FieldOffset(Offset = "0x8")]
      public string uid;
      [Token(Token = "0x4004E15")]
      [FieldOffset(Offset = "0xC")]
      public string name;
      [Token(Token = "0x4004E16")]
      [FieldOffset(Offset = "0x10")]
      public int rank;
      [Token(Token = "0x4004E17")]
      [FieldOffset(Offset = "0x14")]
      public string unit_iname;
      [Token(Token = "0x4004E18")]
      [FieldOffset(Offset = "0x18")]
      public int unit_lv;
      [Token(Token = "0x4004E19")]
      [FieldOffset(Offset = "0x1C")]
      public int job_lv;
      [Token(Token = "0x4004E1A")]
      [FieldOffset(Offset = "0x20")]
      public int main_score;
      [Token(Token = "0x4004E1B")]
      [FieldOffset(Offset = "0x24")]
      public int sub_score;
      [Token(Token = "0x4004E1C")]
      [FieldOffset(Offset = "0x28")]
      public JSON_ViewGuild guild;

      [Token(Token = "0x6005899")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_OthersRankingData()
      {
      }
    }

    [Token(Token = "0x2001575")]
    [Serializable]
    public class Json
    {
      [Token(Token = "0x4004E1D")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_ReqQuestRanking.Json_OwnRankingData my_info;
      [Token(Token = "0x4004E1E")]
      [FieldOffset(Offset = "0xC")]
      public FlowNode_ReqQuestRanking.Json_OthersRankingData[] ranking;

      [Token(Token = "0x600589A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json()
      {
      }
    }
  }
}
