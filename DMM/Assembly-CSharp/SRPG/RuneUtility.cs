// Decompiled with JetBrains decompiler
// Type: SRPG.RuneUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CE6")]
  public class RuneUtility
  {
    [Token(Token = "0x400714C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int CAN_RUNE_DEDICATED_RARITY;
    [Token(Token = "0x400714D")]
    [FieldOffset(Offset = "0x4")]
    public static readonly int CAN_USE_GAUGE_PERCENTAGE;

    [Token(Token = "0x60076B5")]
    [Address(RVA = "0x39E4A0", Offset = "0x39D2A0", VA = "0x1039E4A0")]
    public static List<RuneSetEff> GetEnableRuneSetEffects(RuneData[] runes)
    {
      return (List<RuneSetEff>) null;
    }

    [Token(Token = "0x60076B6")]
    [Address(RVA = "0x39E5C0", Offset = "0x39D3C0", VA = "0x1039E5C0")]
    public static List<RuneSetEff> GetEnableRuneSetEffects(RuneParam[] runeParams)
    {
      return (List<RuneSetEff>) null;
    }

    [Token(Token = "0x60076B7")]
    [Address(RVA = "0x39E370", Offset = "0x39D170", VA = "0x1039E370")]
    public static int CountRuneNum(Json_Item[] items) => new int();

    [Token(Token = "0x60076B8")]
    [Address(RVA = "0x39DFD0", Offset = "0x39CDD0", VA = "0x1039DFD0")]
    public static int CountRuneNum(RewardData reward) => new int();

    [Token(Token = "0x60076B9")]
    [Address(RVA = "0x39DE70", Offset = "0x39CC70", VA = "0x1039DE70")]
    public static int CountRuneNum(BattleCore.Json_BtlInfo[] battleInfo) => new int();

    [Token(Token = "0x60076BA")]
    [Address(RVA = "0x39E2D0", Offset = "0x39D0D0", VA = "0x1039E2D0")]
    public static int CountRuneNum(List<BattleCore.DropItemParam> items) => new int();

    [Token(Token = "0x60076BB")]
    [Address(RVA = "0x39E1A0", Offset = "0x39CFA0", VA = "0x1039E1A0")]
    public static int CountRuneNum(BattleCore.Json_BtlDrop[][] drops) => new int();

    [Token(Token = "0x60076BC")]
    [Address(RVA = "0x39E970", Offset = "0x39D770", VA = "0x1039E970")]
    public static bool IsCanUseGauge(BindRuneData rune) => new bool();

    [Token(Token = "0x60076BD")]
    [Address(RVA = "0x39DD40", Offset = "0x39CB40", VA = "0x1039DD40")]
    public static int CalcPlayerGauge(BindRuneData rune) => new int();

    [Token(Token = "0x60076BE")]
    [Address(RVA = "0x39DE00", Offset = "0x39CC00", VA = "0x1039DE00")]
    public static int CalcSuccessPercentage(BindRuneData bind_rune) => new int();

    [Token(Token = "0x60076BF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneUtility()
    {
    }

    [Token(Token = "0x60076C0")]
    [Address(RVA = "0x39EB00", Offset = "0x39D900", VA = "0x1039EB00")]
    static RuneUtility()
    {
    }
  }
}
