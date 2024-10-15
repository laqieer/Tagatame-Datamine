// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SortRuneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D4D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SortRuneParam
  {
    [Token(Token = "0x400734C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400734D")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x400734E")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x400734F")]
    [FieldOffset(Offset = "0x14")]
    public JSON_SortRuneConditionParam[] cnds;

    [Token(Token = "0x600780E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SortRuneParam()
    {
    }
  }
}
