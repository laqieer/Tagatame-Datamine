// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002822")]
  public class PointQuestRankingData
  {
    [Token(Token = "0x400BF41")]
    [FieldOffset(Offset = "0x8")]
    public string Name;
    [Token(Token = "0x400BF42")]
    [FieldOffset(Offset = "0xC")]
    public int Lv;
    [Token(Token = "0x400BF43")]
    [FieldOffset(Offset = "0x10")]
    public UnitData Unit;
    [Token(Token = "0x400BF44")]
    [FieldOffset(Offset = "0x14")]
    public string SelectedAward;
    [Token(Token = "0x400BF45")]
    [FieldOffset(Offset = "0x18")]
    public int Rank;
    [Token(Token = "0x400BF46")]
    [FieldOffset(Offset = "0x1C")]
    public int Score;
    [Token(Token = "0x400BF47")]
    [FieldOffset(Offset = "0x20")]
    public string TargetQuest;

    [Token(Token = "0x600B51A")]
    [Address(RVA = "0x7BC6F0", Offset = "0x7BB4F0", VA = "0x107BC6F0")]
    public bool Deserialize(JSON_PointQuestRankingData json) => new bool();

    [Token(Token = "0x600B51B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestRankingData()
    {
    }
  }
}
