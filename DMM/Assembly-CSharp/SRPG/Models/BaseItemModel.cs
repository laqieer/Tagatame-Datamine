// Decompiled with JetBrains decompiler
// Type: SRPG.Models.BaseItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200334B")]
  public class BaseItemModel
  {
    [Token(Token = "0x400F20F")]
    [FieldOffset(Offset = "0x8")]
    private ItemParam itemParam;
    [Token(Token = "0x400F210")]
    [FieldOffset(Offset = "0xC")]
    private int itemAmount;
    [Token(Token = "0x400F211")]
    [FieldOffset(Offset = "0x10")]
    private bool isActiveBadgeEquipUnit;
    [Token(Token = "0x400F212")]
    [FieldOffset(Offset = "0x14")]
    private string iname;
    [Token(Token = "0x400F213")]
    [FieldOffset(Offset = "0x18")]
    private Sprite sprite;
    [Token(Token = "0x400F214")]
    [FieldOffset(Offset = "0x1C")]
    private string itemIconPath;

    [Token(Token = "0x17001E62")]
    public ItemParam ItemParam
    {
      [Token(Token = "0x600E2EF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17001E63")]
    public int ItemAmount
    {
      [Token(Token = "0x600E2F0"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E64")]
    public bool IsActiveBadgeEquipUnit
    {
      [Token(Token = "0x600E2F1"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E65")]
    public string Iname
    {
      [Token(Token = "0x600E2F2"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E66")]
    public Sprite Sprite
    {
      [Token(Token = "0x600E2F3"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001E67")]
    public string ItemIconPath
    {
      [Token(Token = "0x600E2F4"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E2F5")]
    [Address(RVA = "0xAA7E20", Offset = "0xAA6C20", VA = "0x10AA7E20")]
    public void Initialize(ItemData itemData)
    {
    }

    [Token(Token = "0x600E2F6")]
    [Address(RVA = "0xAA7F80", Offset = "0xAA6D80", VA = "0x10AA7F80")]
    public void Initialize(ItemParam _itemParam)
    {
    }

    [Token(Token = "0x600E2F7")]
    [Address(RVA = "0xAA80E0", Offset = "0xAA6EE0", VA = "0x10AA80E0")]
    public BaseItemModel()
    {
    }
  }
}
