// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdventureBook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F82")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdventureBook
  {
    [Token(Token = "0x4008518")]
    [FieldOffset(Offset = "0x8")]
    public string area_iname;
    [Token(Token = "0x4008519")]
    [FieldOffset(Offset = "0xC")]
    public JSON_AdventureBook.Item[] book_items;

    [Token(Token = "0x600816E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdventureBook()
    {
    }

    [Token(Token = "0x2001F83")]
    [MessagePackObject(true)]
    [Serializable]
    public class Item
    {
      [Token(Token = "0x400851A")]
      [FieldOffset(Offset = "0x8")]
      public int itype;
      [Token(Token = "0x400851B")]
      [FieldOffset(Offset = "0xC")]
      public string iname;
      [Token(Token = "0x400851C")]
      [FieldOffset(Offset = "0x10")]
      public int is_open;
      [Token(Token = "0x400851D")]
      [FieldOffset(Offset = "0x14")]
      public int is_new;

      [Token(Token = "0x600816F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Item()
      {
      }
    }
  }
}
