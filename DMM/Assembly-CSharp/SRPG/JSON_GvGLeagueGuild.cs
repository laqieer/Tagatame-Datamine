// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGLeagueGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025AE")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGLeagueGuild
  {
    [Token(Token = "0x400AEF0")]
    [FieldOffset(Offset = "0x8")]
    public int gid;
    [Token(Token = "0x400AEF1")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400AEF2")]
    [FieldOffset(Offset = "0x10")]
    public JSON_GvGLeagueData league;

    [Token(Token = "0x600A757")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGLeagueGuild()
    {
    }
  }
}
