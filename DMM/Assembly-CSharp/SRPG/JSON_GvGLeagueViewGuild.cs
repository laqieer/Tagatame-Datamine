// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGLeagueViewGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025AD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGLeagueViewGuild : JSON_ViewGuild
  {
    [Token(Token = "0x400AEEF")]
    [FieldOffset(Offset = "0x30")]
    public JSON_GvGLeagueData league;

    [Token(Token = "0x600A756")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public JSON_GvGLeagueViewGuild()
    {
    }
  }
}
