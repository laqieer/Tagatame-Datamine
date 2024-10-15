// Decompiled with JetBrains decompiler
// Type: SRPG.DuelChainWinPointParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AC0")]
  public class DuelChainWinPointParam
  {
    [Token(Token = "0x4006327")]
    [FieldOffset(Offset = "0x8")]
    private int mChain;
    [Token(Token = "0x4006328")]
    [FieldOffset(Offset = "0xC")]
    private int mPointBonus;

    [Token(Token = "0x17000C69")]
    public int Chain
    {
      [Token(Token = "0x6006E40"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C6A")]
    public int PointBonus
    {
      [Token(Token = "0x6006E41"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E42")]
    [Address(RVA = "0x319840", Offset = "0x318640", VA = "0x10319840")]
    public void Deserialize(JSON_DuelChainWinPointParam json)
    {
    }

    [Token(Token = "0x6006E43")]
    [Address(RVA = "0x35EBA0", Offset = "0x35D9A0", VA = "0x1035EBA0")]
    public static void Deserialize(
      ref DuelChainWinPointParam[] param,
      JSON_DuelChainWinPointParam[] json)
    {
    }

    [Token(Token = "0x6006E44")]
    [Address(RVA = "0x35ECC0", Offset = "0x35DAC0", VA = "0x1035ECC0")]
    public static DuelChainWinPointParam GetParam(int chain_win) => (DuelChainWinPointParam) null;

    [Token(Token = "0x6006E45")]
    [Address(RVA = "0x35F040", Offset = "0x35DE40", VA = "0x1035F040")]
    public static bool IsBounus() => new bool();

    [Token(Token = "0x6006E46")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DuelChainWinPointParam()
    {
    }
  }
}
