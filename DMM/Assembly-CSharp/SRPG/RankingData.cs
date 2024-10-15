// Decompiled with JetBrains decompiler
// Type: SRPG.RankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001583")]
  public class RankingData
  {
    [Token(Token = "0x4004E59")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4004E5A")]
    [FieldOffset(Offset = "0xC")]
    public RankingUnitData[] ranking;
    [Token(Token = "0x4004E5B")]
    [FieldOffset(Offset = "0x10")]
    public int isReady;

    [Token(Token = "0x60058BE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RankingData()
    {
    }
  }
}
