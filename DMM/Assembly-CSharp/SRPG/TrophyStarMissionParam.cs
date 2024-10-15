// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyStarMissionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DA2")]
  public class TrophyStarMissionParam
  {
    [Token(Token = "0x4007608")]
    [FieldOffset(Offset = "0x8")]
    public string Iname;
    [Token(Token = "0x4007609")]
    [FieldOffset(Offset = "0xC")]
    public TrophyStarMissionParam.eStarMissionType Type;
    [Token(Token = "0x400760A")]
    [FieldOffset(Offset = "0x10")]
    public DateTime BeginAt;
    [Token(Token = "0x400760B")]
    [FieldOffset(Offset = "0x18")]
    public DateTime EndAt;
    [Token(Token = "0x400760C")]
    [FieldOffset(Offset = "0x20")]
    private TrophyStarMissionParam.StarSetParam[] mStarSets;
    [Token(Token = "0x400760D")]
    [FieldOffset(Offset = "0x0")]
    public static TrophyStarMissionParam.eStarMissionType SelectStarMissionType;
    [Token(Token = "0x400760E")]
    [FieldOffset(Offset = "0x4")]
    public static int SelectDailyTreasureIndex;
    [Token(Token = "0x400760F")]
    [FieldOffset(Offset = "0x8")]
    public static int SelectWeeklyTreasureIndex;

    [Token(Token = "0x17001053")]
    public List<TrophyStarMissionParam.StarSetParam> StarSetList
    {
      [Token(Token = "0x6007948"), Address(RVA = "0x3B0B80", Offset = "0x3AF980", VA = "0x103B0B80")] get
      {
        return (List<TrophyStarMissionParam.StarSetParam>) null;
      }
    }

    [Token(Token = "0x6007949")]
    [Address(RVA = "0x3B03F0", Offset = "0x3AF1F0", VA = "0x103B03F0")]
    public void Deserialize(JSON_TrophyStarMissionParam json)
    {
    }

    [Token(Token = "0x600794A")]
    [Address(RVA = "0x3B06D0", Offset = "0x3AF4D0", VA = "0x103B06D0")]
    public static void Deserialize(
      JSON_TrophyStarMissionParam[] json,
      ref Dictionary<string, TrophyStarMissionParam> dict)
    {
    }

    [Token(Token = "0x600794B")]
    [Address(RVA = "0x3B0970", Offset = "0x3AF770", VA = "0x103B0970")]
    public static TrophyStarMissionParam GetParam(string key) => (TrophyStarMissionParam) null;

    [Token(Token = "0x600794C")]
    [Address(RVA = "0x3B0840", Offset = "0x3AF640", VA = "0x103B0840")]
    public static bool EntryTrophyStarMission(ReqTrophyStarMission.StarMission star_mission)
    {
      return new bool();
    }

    [Token(Token = "0x600794D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TrophyStarMissionParam()
    {
    }

    [Token(Token = "0x600794E")]
    [Address(RVA = "0x3B0B40", Offset = "0x3AF940", VA = "0x103B0B40")]
    static TrophyStarMissionParam()
    {
    }

    [Token(Token = "0x2001DA3")]
    public enum eStarMissionType
    {
      [Token(Token = "0x4007611")] DAILY,
      [Token(Token = "0x4007612")] WEEKLY,
    }

    [Token(Token = "0x2001DA4")]
    public class StarSetParam
    {
      [Token(Token = "0x4007613")]
      [FieldOffset(Offset = "0x8")]
      public OInt RequireStar;
      [Token(Token = "0x4007614")]
      [FieldOffset(Offset = "0x1C")]
      public string TsmRewardId;
      [Token(Token = "0x4007615")]
      [FieldOffset(Offset = "0x20")]
      public int IconIndex;
      [Token(Token = "0x4007616")]
      [FieldOffset(Offset = "0x24")]
      private TrophyStarMissionRewardParam mTsmReward;

      [Token(Token = "0x17001054")]
      public TrophyStarMissionRewardParam TsmReward
      {
        [Token(Token = "0x600794F"), Address(RVA = "0x3A3300", Offset = "0x3A2100", VA = "0x103A3300")] get
        {
          return (TrophyStarMissionRewardParam) null;
        }
      }

      [Token(Token = "0x6007950")]
      [Address(RVA = "0x3A32B0", Offset = "0x3A20B0", VA = "0x103A32B0")]
      public void Deserialize(JSON_TrophyStarMissionParam.StarSetParam json)
      {
      }

      [Token(Token = "0x6007951")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public StarSetParam()
      {
      }
    }
  }
}
