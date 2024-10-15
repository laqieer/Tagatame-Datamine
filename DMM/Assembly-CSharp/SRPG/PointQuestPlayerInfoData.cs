// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestPlayerInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002826")]
  public class PointQuestPlayerInfoData
  {
    [Token(Token = "0x400BF55")]
    [FieldOffset(Offset = "0x8")]
    public string Name;
    [Token(Token = "0x400BF56")]
    [FieldOffset(Offset = "0xC")]
    public int Level;
    [Token(Token = "0x400BF57")]
    [FieldOffset(Offset = "0x10")]
    public UnitData Unit;
    [Token(Token = "0x400BF58")]
    [FieldOffset(Offset = "0x14")]
    public PointQuestGuildData Guild;
    [Token(Token = "0x400BF59")]
    [FieldOffset(Offset = "0x18")]
    public int TotalPoint;
    [Token(Token = "0x400BF5A")]
    [FieldOffset(Offset = "0x1C")]
    public int Rank;

    [Token(Token = "0x600B522")]
    [Address(RVA = "0x7BC350", Offset = "0x7BB150", VA = "0x107BC350")]
    public bool Deserialize(JSON_PointQuestPlayerInfoData json) => new bool();

    [Token(Token = "0x600B523")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestPlayerInfoData()
    {
    }
  }
}
