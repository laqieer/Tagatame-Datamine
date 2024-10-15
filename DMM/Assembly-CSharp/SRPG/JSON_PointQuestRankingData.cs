// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PointQuestRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002815")]
  [MessagePackObject(true)]
  public class JSON_PointQuestRankingData
  {
    [Token(Token = "0x400BEFD")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x400BEFE")]
    [FieldOffset(Offset = "0xC")]
    public int lv;
    [Token(Token = "0x400BEFF")]
    [FieldOffset(Offset = "0x10")]
    public Json_Unit unit;
    [Token(Token = "0x400BF00")]
    [FieldOffset(Offset = "0x14")]
    public string selected_award;
    [Token(Token = "0x400BF01")]
    [FieldOffset(Offset = "0x18")]
    public int rank;
    [Token(Token = "0x400BF02")]
    [FieldOffset(Offset = "0x1C")]
    public int score;
    [Token(Token = "0x400BF03")]
    [FieldOffset(Offset = "0x20")]
    public string target_quest;
    [Token(Token = "0x400BF04")]
    [FieldOffset(Offset = "0x24")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x600B50C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PointQuestRankingData()
    {
    }
  }
}
