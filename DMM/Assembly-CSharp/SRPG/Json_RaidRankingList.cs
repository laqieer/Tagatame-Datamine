// Decompiled with JetBrains decompiler
// Type: SRPG.Json_RaidRankingList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010D1")]
  [Serializable]
  public class Json_RaidRankingList
  {
    [Token(Token = "0x4003CAE")]
    [FieldOffset(Offset = "0x8")]
    public Json_RaidRankingData my_info;
    [Token(Token = "0x4003CAF")]
    [FieldOffset(Offset = "0xC")]
    public Json_RaidRankingData[] ranking;
    [Token(Token = "0x4003CB0")]
    [FieldOffset(Offset = "0x10")]
    public int total_page;

    [Token(Token = "0x6004720")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_RaidRankingList()
    {
    }
  }
}
