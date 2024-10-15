// Decompiled with JetBrains decompiler
// Type: SRPG.SupportUnitRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B18")]
  public class SupportUnitRanking
  {
    [Token(Token = "0x400D25C")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x400D25D")]
    [FieldOffset(Offset = "0xC")]
    public int score;
    [Token(Token = "0x400D25E")]
    [FieldOffset(Offset = "0x10")]
    public UnitData unit;
    [Token(Token = "0x400D25F")]
    [FieldOffset(Offset = "0x14")]
    public string jobName;

    [Token(Token = "0x600C540")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SupportUnitRanking()
    {
    }
  }
}
