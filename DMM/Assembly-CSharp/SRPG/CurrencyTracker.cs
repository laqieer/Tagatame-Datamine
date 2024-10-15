// Decompiled with JetBrains decompiler
// Type: SRPG.CurrencyTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F6B")]
  public class CurrencyTracker
  {
    [Token(Token = "0x400350D")]
    [FieldOffset(Offset = "0x8")]
    public int Gold;
    [Token(Token = "0x400350E")]
    [FieldOffset(Offset = "0xC")]
    public int Coin;
    [Token(Token = "0x400350F")]
    [FieldOffset(Offset = "0x10")]
    public int ArenaCoin;
    [Token(Token = "0x4003510")]
    [FieldOffset(Offset = "0x14")]
    public int MultiCoin;

    [Token(Token = "0x6004026")]
    [Address(RVA = "0x118D410", Offset = "0x118C210", VA = "0x1118D410")]
    public CurrencyTracker()
    {
    }

    [Token(Token = "0x6004027")]
    [Address(RVA = "0x118D380", Offset = "0x118C180", VA = "0x1118D380")]
    public void EndTracking()
    {
    }
  }
}
