// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalSortParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AA1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalSortParam
  {
    [Token(Token = "0x40062B0")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40062B1")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x40062B2")]
    [FieldOffset(Offset = "0x10")]
    public string item_name;
    [Token(Token = "0x40062B3")]
    [FieldOffset(Offset = "0x14")]
    public string sub_item_name;
    [Token(Token = "0x40062B4")]
    [FieldOffset(Offset = "0x18")]
    public JSON_CrystalSortCondParam[] cnds;

    [Token(Token = "0x6006DC3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalSortParam()
    {
    }
  }
}
