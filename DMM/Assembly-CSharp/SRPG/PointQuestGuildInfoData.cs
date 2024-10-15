// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestGuildInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002827")]
  public class PointQuestGuildInfoData
  {
    [Token(Token = "0x400BF5B")]
    [FieldOffset(Offset = "0x8")]
    public int Id;
    [Token(Token = "0x400BF5C")]
    [FieldOffset(Offset = "0xC")]
    public string Name;
    [Token(Token = "0x400BF5D")]
    [FieldOffset(Offset = "0x10")]
    public string AwardId;
    [Token(Token = "0x400BF5E")]
    [FieldOffset(Offset = "0x14")]
    public int Level;
    [Token(Token = "0x400BF5F")]
    [FieldOffset(Offset = "0x18")]
    public int TotalPoint;
    [Token(Token = "0x400BF60")]
    [FieldOffset(Offset = "0x1C")]
    public int Rank;

    [Token(Token = "0x600B524")]
    [Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x107BADC0")]
    public bool Deserialize(JSON_PointQuestGuildInfoData json) => new bool();

    [Token(Token = "0x600B525")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestGuildInfoData()
    {
    }
  }
}
