// Decompiled with JetBrains decompiler
// Type: SRPG.BondBadgeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020A3")]
  public class BondBadgeManager
  {
    [Token(Token = "0x4008C9C")]
    [FieldOffset(Offset = "0x0")]
    private static List<BondBadgeData> mBondBadgeDatas;

    [Token(Token = "0x60087D3")]
    [Address(RVA = "0x48F5C0", Offset = "0x48E3C0", VA = "0x1048F5C0")]
    private static List<BondBadgeData> GetBondBadgeInfo() => (List<BondBadgeData>) null;

    [Token(Token = "0x60087D4")]
    [Address(RVA = "0x4900E0", Offset = "0x48EEE0", VA = "0x104900E0")]
    private static bool SetBondBadgeInfo(List<BondBadgeData> new_badge_datas) => new bool();

    [Token(Token = "0x60087D5")]
    [Address(RVA = "0x48F790", Offset = "0x48E590", VA = "0x1048F790")]
    public static bool IsBadgeTopEnable(bool is_new_group_check = true) => new bool();

    [Token(Token = "0x60087D6")]
    [Address(RVA = "0x48FD60", Offset = "0x48EB60", VA = "0x1048FD60")]
    public static bool IsBannerBadgeCheck(string iname) => new bool();

    [Token(Token = "0x60087D7")]
    [Address(RVA = "0x48FC40", Offset = "0x48EA40", VA = "0x1048FC40")]
    public static bool IsBannerBadgeAnimeCheck(string iname) => new bool();

    [Token(Token = "0x60087D8")]
    [Address(RVA = "0x48FF20", Offset = "0x48ED20", VA = "0x1048FF20")]
    public static bool SetBondBadgeData(string iname, DateTime now, bool is_top, bool is_open_anm = false)
    {
      return new bool();
    }

    [Token(Token = "0x60087D9")]
    [Address(RVA = "0x48FE30", Offset = "0x48EC30", VA = "0x1048FE30")]
    public static bool RemoveBondBadgeData(string iname) => new bool();

    [Token(Token = "0x60087DA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondBadgeManager()
    {
    }
  }
}
