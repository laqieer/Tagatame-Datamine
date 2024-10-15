// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePridePotentialSlotData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011C9")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePridePotentialSlotData
  {
    [Token(Token = "0x40040A8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40040A9")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x40040AA")]
    [FieldOffset(Offset = "0x10")]
    public int ex_type;
    [Token(Token = "0x40040AB")]
    [FieldOffset(Offset = "0x14")]
    public int calc_type;
    [Token(Token = "0x40040AC")]
    [FieldOffset(Offset = "0x18")]
    public int val;
    [Token(Token = "0x40040AD")]
    [FieldOffset(Offset = "0x1C")]
    public string tag;

    [Token(Token = "0x6004B42")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePridePotentialSlotData()
    {
    }
  }
}
