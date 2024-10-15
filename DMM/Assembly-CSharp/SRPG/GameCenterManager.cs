// Decompiled with JetBrains decompiler
// Type: SRPG.GameCenterManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F30")]
  public class GameCenterManager
  {
    [Token(Token = "0x4002F5B")]
    [FieldOffset(Offset = "0x0")]
    private static List<AchievementParam> mAchievementList;

    [Token(Token = "0x6003F5F")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")]
    public static bool isValidEnvironment() => new bool();

    [Token(Token = "0x6003F60")]
    [Address(RVA = "0x1179320", Offset = "0x1178120", VA = "0x11179320")]
    public static void Auth()
    {
    }

    [Token(Token = "0x6003F61")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public static void ReAuth()
    {
    }

    [Token(Token = "0x6003F62")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")]
    public static bool IsAuth() => new bool();

    [Token(Token = "0x6003F63")]
    [Address(RVA = "0x11796C0", Offset = "0x11784C0", VA = "0x111796C0")]
    private static void ProcessAuthGameCenter(bool success)
    {
    }

    [Token(Token = "0x6003F64")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public static void ShowLeaderBoard()
    {
    }

    [Token(Token = "0x6003F65")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public static void ShowAchievement()
    {
    }

    [Token(Token = "0x6003F66")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public static void SendLeaderBoardScore(string leader_board_id, long score)
    {
    }

    [Token(Token = "0x17000555")]
    public static bool IsLogin
    {
      [Token(Token = "0x6003F67"), Address(RVA = "0x11797F0", Offset = "0x11785F0", VA = "0x111797F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003F68")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public static void SendAchievementProgress(string achievement_id, long progress)
    {
    }

    [Token(Token = "0x6003F69")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public static void GetLeaderboardData()
    {
    }

    [Token(Token = "0x6003F6A")]
    [Address(RVA = "0x1179340", Offset = "0x1178140", VA = "0x11179340")]
    public static List<AchievementParam> GetAchievementData() => (List<AchievementParam>) null;

    [Token(Token = "0x6003F6B")]
    [Address(RVA = "0x1179540", Offset = "0x1178340", VA = "0x11179540")]
    private static AchievementParam GetAchievementParam(string iname) => (AchievementParam) null;

    [Token(Token = "0x6003F6C")]
    [Address(RVA = "0x11797A0", Offset = "0x11785A0", VA = "0x111797A0")]
    public static void SendAchievementProgress(string iname)
    {
    }

    [Token(Token = "0x6003F6D")]
    [Address(RVA = "0x1179760", Offset = "0x1178560", VA = "0x11179760")]
    public static void SendAchievementProgress(AchievementParam param)
    {
    }

    [Token(Token = "0x6003F6E")]
    [Address(RVA = "0x1179750", Offset = "0x1178550", VA = "0x11179750")]
    public static void SendAchievementProgressInternal(string achievementID)
    {
    }

    [Token(Token = "0x6003F6F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GameCenterManager()
    {
    }
  }
}
