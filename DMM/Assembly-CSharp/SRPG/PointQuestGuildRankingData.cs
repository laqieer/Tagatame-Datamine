// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestGuildRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002823")]
  public class PointQuestGuildRankingData
  {
    [Token(Token = "0x400BF48")]
    [FieldOffset(Offset = "0x8")]
    public int GuildID;
    [Token(Token = "0x400BF49")]
    [FieldOffset(Offset = "0xC")]
    public string Name;
    [Token(Token = "0x400BF4A")]
    [FieldOffset(Offset = "0x10")]
    public int Lv;
    [Token(Token = "0x400BF4B")]
    [FieldOffset(Offset = "0x14")]
    public string AwardID;
    [Token(Token = "0x400BF4C")]
    [FieldOffset(Offset = "0x18")]
    public int Rank;
    [Token(Token = "0x400BF4D")]
    [FieldOffset(Offset = "0x1C")]
    public int Score;
    [Token(Token = "0x400BF4E")]
    [FieldOffset(Offset = "0x20")]
    public string MasterName;

    [Token(Token = "0x600B51C")]
    [Address(RVA = "0x7BAE20", Offset = "0x7B9C20", VA = "0x107BAE20")]
    public bool Deserialize(JSON_PointQuestGuildRankingData json) => new bool();

    [Token(Token = "0x600B51D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestGuildRankingData()
    {
    }
  }
}
