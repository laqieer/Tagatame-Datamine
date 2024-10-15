// Decompiled with JetBrains decompiler
// Type: SRPG.BookmarkDropData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C59")]
  [MessagePackObject(true)]
  [Serializable]
  public class BookmarkDropData
  {
    [Token(Token = "0x17000EEE")]
    public string Iname
    {
      [Token(Token = "0x600750E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600750F"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000EEF")]
    public int Num
    {
      [Token(Token = "0x6007510"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007511"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x6007512")]
    [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
    public bool Deserialize(JSON_BookmarkDropItem json) => new bool();

    [Token(Token = "0x6007513")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BookmarkDropData()
    {
    }
  }
}
