// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalSetBonusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A9E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalSetBonusParam
  {
    [Token(Token = "0x400629C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400629D")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400629E")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x400629F")]
    [FieldOffset(Offset = "0x14")]
    public string main_crystal;
    [Token(Token = "0x40062A0")]
    [FieldOffset(Offset = "0x18")]
    public string[] sub_crystals;
    [Token(Token = "0x40062A1")]
    [FieldOffset(Offset = "0x1C")]
    public string buff_iname;
    [Token(Token = "0x40062A2")]
    [FieldOffset(Offset = "0x20")]
    public string add_limit;

    [Token(Token = "0x6006DB0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalSetBonusParam()
    {
    }
  }
}
