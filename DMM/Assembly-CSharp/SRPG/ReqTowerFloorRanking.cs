// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTowerFloorRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031B3")]
  public class ReqTowerFloorRanking : WebAPI
  {
    [Token(Token = "0x600DE4D")]
    [Address(RVA = "0xA9E800", Offset = "0xA9D600", VA = "0x10A9E800")]
    public ReqTowerFloorRanking(
      string tower_iname,
      string floor_iname,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031B4")]
    [Serializable]
    public class Json_Response
    {
      [Token(Token = "0x400ED6B")]
      [FieldOffset(Offset = "0x8")]
      public ReqTowerRank.JSON_TowerRankParam[] speed;
      [Token(Token = "0x400ED6C")]
      [FieldOffset(Offset = "0xC")]
      public ReqTowerRank.JSON_TowerRankParam[] technical;
      [Token(Token = "0x400ED6D")]
      [FieldOffset(Offset = "0x10")]
      public ReqTowerFloorRanking.Json_Score score;

      [Token(Token = "0x600DE4E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Response()
      {
      }
    }

    [Token(Token = "0x20031B5")]
    [Serializable]
    public class Json_Score
    {
      [Token(Token = "0x400ED6E")]
      [FieldOffset(Offset = "0x8")]
      public int turn_num;
      [Token(Token = "0x400ED6F")]
      [FieldOffset(Offset = "0xC")]
      public int died_num;
      [Token(Token = "0x400ED70")]
      [FieldOffset(Offset = "0x10")]
      public int retire_num;
      [Token(Token = "0x400ED71")]
      [FieldOffset(Offset = "0x14")]
      public int recovery_num;
      [Token(Token = "0x400ED72")]
      [FieldOffset(Offset = "0x18")]
      public int reset_num;
      [Token(Token = "0x400ED73")]
      [FieldOffset(Offset = "0x1C")]
      public int lose_num;
      [Token(Token = "0x400ED74")]
      [FieldOffset(Offset = "0x20")]
      public int challenge_num;

      [Token(Token = "0x600DE4F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_Score()
      {
      }
    }
  }
}
