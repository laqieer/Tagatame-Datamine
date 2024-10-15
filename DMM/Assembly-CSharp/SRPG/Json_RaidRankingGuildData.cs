// Decompiled with JetBrains decompiler
// Type: SRPG.Json_RaidRankingGuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010D4")]
  [Serializable]
  public class Json_RaidRankingGuildData
  {
    [Token(Token = "0x4003CBC")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x4003CBD")]
    [FieldOffset(Offset = "0xC")]
    public int score;
    [Token(Token = "0x4003CBE")]
    [FieldOffset(Offset = "0x10")]
    public JSON_ViewGuild guild;

    [Token(Token = "0x6004723")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_RaidRankingGuildData()
    {
    }
  }
}
