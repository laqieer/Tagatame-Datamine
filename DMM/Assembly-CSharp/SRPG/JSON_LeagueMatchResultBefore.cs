// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchResultBefore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011A9")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchResultBefore
  {
    [Token(Token = "0x4004022")]
    [FieldOffset(Offset = "0x8")]
    public JSON_LeagueMatchResultBeforeOffense offense;
    [Token(Token = "0x4004023")]
    [FieldOffset(Offset = "0xC")]
    public JSON_LeagueMatchResultBeforeDefense defense;
    [Token(Token = "0x4004024")]
    [FieldOffset(Offset = "0x10")]
    public JSON_LeagueMatchResultBeforeRank before;

    [Token(Token = "0x6004B23")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchResultBefore()
    {
    }
  }
}
