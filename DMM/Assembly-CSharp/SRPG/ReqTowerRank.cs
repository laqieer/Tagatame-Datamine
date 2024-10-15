// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTowerRank
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031AB")]
  public class ReqTowerRank : WebAPI
  {
    [Token(Token = "0x600DE45")]
    [Address(RVA = "0xA9EA40", Offset = "0xA9D840", VA = "0x10A9EA40")]
    public ReqTowerRank(string qid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031AC")]
    public class JSON_TowerRankParam
    {
      [Token(Token = "0x400ED59")]
      [FieldOffset(Offset = "0x8")]
      public string fuid;
      [Token(Token = "0x400ED5A")]
      [FieldOffset(Offset = "0xC")]
      public string name;
      [Token(Token = "0x400ED5B")]
      [FieldOffset(Offset = "0x10")]
      public int lv;
      [Token(Token = "0x400ED5C")]
      [FieldOffset(Offset = "0x14")]
      public int rank;
      [Token(Token = "0x400ED5D")]
      [FieldOffset(Offset = "0x18")]
      public int score;
      [Token(Token = "0x400ED5E")]
      [FieldOffset(Offset = "0x1C")]
      public string uid;
      [Token(Token = "0x400ED5F")]
      [FieldOffset(Offset = "0x20")]
      public Json_Unit unit;
      [Token(Token = "0x400ED60")]
      [FieldOffset(Offset = "0x24")]
      public string selected_award;
      [Token(Token = "0x400ED61")]
      [FieldOffset(Offset = "0x28")]
      public JSON_ViewGuild guild;

      [Token(Token = "0x600DE46")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_TowerRankParam()
      {
      }
    }

    [Token(Token = "0x20031AD")]
    public class JSON_TowerRankResponse
    {
      [Token(Token = "0x400ED62")]
      [FieldOffset(Offset = "0x8")]
      public ReqTowerRank.JSON_TowerRankParam[] speed;
      [Token(Token = "0x400ED63")]
      [FieldOffset(Offset = "0xC")]
      public ReqTowerRank.JSON_TowerRankParam[] technical;
      [Token(Token = "0x400ED64")]
      [FieldOffset(Offset = "0x10")]
      public JSON_ReqTowerResuponse.Json_RankStatus rank;

      [Token(Token = "0x600DE47")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_TowerRankResponse()
      {
      }
    }
  }
}
