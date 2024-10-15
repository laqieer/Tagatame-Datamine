// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_FilterRuneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D36")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_FilterRuneParam
  {
    [Token(Token = "0x40072B1")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40072B2")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x40072B3")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x40072B4")]
    [FieldOffset(Offset = "0x14")]
    public int filter_type;
    [Token(Token = "0x40072B5")]
    [FieldOffset(Offset = "0x18")]
    public JSON_FilterRuneConditionParam[] cnds;

    [Token(Token = "0x60077BF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_FilterRuneParam()
    {
    }
  }
}
