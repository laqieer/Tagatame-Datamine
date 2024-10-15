// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchDefenseFixInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011A0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchDefenseFixInfo
  {
    [Token(Token = "0x4004006")]
    [FieldOffset(Offset = "0x8")]
    public string map;
    [Token(Token = "0x4004007")]
    [FieldOffset(Offset = "0xC")]
    public Json_Unit[] units;

    [Token(Token = "0x6004B1A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchDefenseFixInfo()
    {
    }
  }
}
