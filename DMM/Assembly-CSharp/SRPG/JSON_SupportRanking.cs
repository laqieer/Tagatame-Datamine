// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SupportRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200103F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SupportRanking
  {
    [Token(Token = "0x40039DE")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x40039DF")]
    [FieldOffset(Offset = "0xC")]
    public int score;
    [Token(Token = "0x40039E0")]
    [FieldOffset(Offset = "0x10")]
    public string uid;
    [Token(Token = "0x40039E1")]
    [FieldOffset(Offset = "0x14")]
    public int lv;
    [Token(Token = "0x40039E2")]
    [FieldOffset(Offset = "0x18")]
    public string name;
    [Token(Token = "0x40039E3")]
    [FieldOffset(Offset = "0x1C")]
    public string selected_award;
    [Token(Token = "0x40039E4")]
    [FieldOffset(Offset = "0x20")]
    public Json_Unit unit;
    [Token(Token = "0x40039E5")]
    [FieldOffset(Offset = "0x24")]
    public JSON_SupportRankingGuild guild;

    [Token(Token = "0x60042B1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SupportRanking()
    {
    }
  }
}
