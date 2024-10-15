// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureBook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F89")]
  public class AdventureBook
  {
    [Token(Token = "0x4008532")]
    [FieldOffset(Offset = "0x8")]
    private string mAreaIname;
    [Token(Token = "0x4008533")]
    [FieldOffset(Offset = "0xC")]
    private List<AdventureBook.Item> mItemList;

    [Token(Token = "0x17001297")]
    public string AreaIname
    {
      [Token(Token = "0x6008189"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001298")]
    public List<AdventureBook.Item> ItemList
    {
      [Token(Token = "0x600818A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<AdventureBook.Item>) null;
      }
    }

    [Token(Token = "0x600818B")]
    [Address(RVA = "0x41D270", Offset = "0x41C070", VA = "0x1041D270")]
    public bool Deserialize(JSON_AdventureBook json) => new bool();

    [Token(Token = "0x600818C")]
    [Address(RVA = "0x41D3C0", Offset = "0x41C1C0", VA = "0x1041D3C0")]
    public AdventureBook()
    {
    }

    [Token(Token = "0x2001F8A")]
    public class Item
    {
      [Token(Token = "0x4008534")]
      [FieldOffset(Offset = "0x8")]
      private RewardIcon.eType mItemType;
      [Token(Token = "0x4008535")]
      [FieldOffset(Offset = "0xC")]
      private string mItemIname;
      [Token(Token = "0x4008536")]
      [FieldOffset(Offset = "0x10")]
      private bool mIsOpen;
      [Token(Token = "0x4008537")]
      [FieldOffset(Offset = "0x11")]
      private bool mIsNew;
      [Token(Token = "0x4008538")]
      [FieldOffset(Offset = "0x14")]
      private ItemParam mItemParam;

      [Token(Token = "0x17001299")]
      public RewardIcon.eType ItemType
      {
        [Token(Token = "0x600818D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new RewardIcon.eType();
        }
      }

      [Token(Token = "0x1700129A")]
      public string ItemIname
      {
        [Token(Token = "0x600818E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700129B")]
      public bool IsOpen
      {
        [Token(Token = "0x600818F"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x1700129C")]
      public bool IsNew
      {
        [Token(Token = "0x6008190"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x1700129D")]
      public ItemParam ItemParam
      {
        [Token(Token = "0x6008191"), Address(RVA = "0x42CCD0", Offset = "0x42BAD0", VA = "0x1042CCD0")] get
        {
          return (ItemParam) null;
        }
      }

      [Token(Token = "0x6008192")]
      [Address(RVA = "0x42CC80", Offset = "0x42BA80", VA = "0x1042CC80")]
      public bool Deserialize(JSON_AdventureBook.Item json_item) => new bool();

      [Token(Token = "0x6008193")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Item()
      {
      }
    }
  }
}
