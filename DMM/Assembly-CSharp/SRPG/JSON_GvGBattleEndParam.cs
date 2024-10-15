// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGBattleEndParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025A9")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGBattleEndParam
  {
    [Token(Token = "0x400AEDE")]
    [FieldOffset(Offset = "0x8")]
    public string result;
    [Token(Token = "0x400AEDF")]
    [FieldOffset(Offset = "0xC")]
    public JSON_GvGPartyUnit[] units;
    [Token(Token = "0x400AEE0")]
    [FieldOffset(Offset = "0x10")]
    public JSON_GvGParty defense;

    [Token(Token = "0x600A752")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGBattleEndParam()
    {
    }
  }
}
