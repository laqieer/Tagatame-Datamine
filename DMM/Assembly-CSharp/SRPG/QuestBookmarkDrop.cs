// Decompiled with JetBrains decompiler
// Type: SRPG.QuestBookmarkDrop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C5A")]
  [MessagePackObject(true)]
  [Serializable]
  public class QuestBookmarkDrop
  {
    [Token(Token = "0x17000EF0")]
    public int Gold
    {
      [Token(Token = "0x6007514"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007515"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000EF1")]
    public List<BookmarkDropData> Items
    {
      [Token(Token = "0x6007516"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<BookmarkDropData>) null;
      }
      [Token(Token = "0x6007517"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6007518")]
    [Address(RVA = "0x391EF0", Offset = "0x390CF0", VA = "0x10391EF0")]
    public bool Deserialize(JSON_QuestBookmarkDrop json) => new bool();

    [Token(Token = "0x6007519")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestBookmarkDrop()
    {
    }
  }
}
