// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011A3")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchSet
  {
    [Token(Token = "0x4004011")]
    [FieldOffset(Offset = "0x8")]
    public long unit_iid;
    [Token(Token = "0x4004012")]
    [FieldOffset(Offset = "0x10")]
    public int place_index;

    [Token(Token = "0x6004B1D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchSet()
    {
    }
  }
}
