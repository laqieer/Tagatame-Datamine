// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PointQuestGuildInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200281A")]
  [MessagePackObject(true)]
  public class JSON_PointQuestGuildInfoData
  {
    [Token(Token = "0x400BF18")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400BF19")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400BF1A")]
    [FieldOffset(Offset = "0x10")]
    public string award_id;
    [Token(Token = "0x400BF1B")]
    [FieldOffset(Offset = "0x14")]
    public int level;
    [Token(Token = "0x400BF1C")]
    [FieldOffset(Offset = "0x18")]
    public int total_point;
    [Token(Token = "0x400BF1D")]
    [FieldOffset(Offset = "0x1C")]
    public int rank;

    [Token(Token = "0x600B511")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PointQuestGuildInfoData()
    {
    }
  }
}
