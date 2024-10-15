// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PointQuestGuildRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002816")]
  [MessagePackObject(true)]
  public class JSON_PointQuestGuildRankingData
  {
    [Token(Token = "0x400BF05")]
    [FieldOffset(Offset = "0x8")]
    public int gid;
    [Token(Token = "0x400BF06")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400BF07")]
    [FieldOffset(Offset = "0x10")]
    public int lv;
    [Token(Token = "0x400BF08")]
    [FieldOffset(Offset = "0x14")]
    public string award_id;
    [Token(Token = "0x400BF09")]
    [FieldOffset(Offset = "0x18")]
    public int rank;
    [Token(Token = "0x400BF0A")]
    [FieldOffset(Offset = "0x1C")]
    public int score;
    [Token(Token = "0x400BF0B")]
    [FieldOffset(Offset = "0x20")]
    public string master_name;

    [Token(Token = "0x600B50D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PointQuestGuildRankingData()
    {
    }
  }
}
