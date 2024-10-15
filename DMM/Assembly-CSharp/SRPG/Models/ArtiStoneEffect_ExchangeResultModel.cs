// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ArtiStoneEffect_ExchangeResultModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003309")]
  public class ArtiStoneEffect_ExchangeResultModel
  {
    [Token(Token = "0x400F04B")]
    [FieldOffset(Offset = "0x8")]
    private ItemData mItemData;
    [Token(Token = "0x400F04C")]
    [FieldOffset(Offset = "0xC")]
    private ItemParam mItemParam;
    [Token(Token = "0x400F04D")]
    [FieldOffset(Offset = "0x10")]
    private int mAddNum;
    [Token(Token = "0x400F04E")]
    [FieldOffset(Offset = "0x14")]
    private string mItemIconPath;
    [Token(Token = "0x400F04F")]
    [FieldOffset(Offset = "0x18")]
    private Sprite mItemFrameSprite;
    [Token(Token = "0x400F050")]
    [FieldOffset(Offset = "0x1C")]
    private string mItemName;

    [Token(Token = "0x17001D4F")]
    public ItemData ItemData
    {
      [Token(Token = "0x600E04A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17001D50")]
    public ItemParam ItemParam
    {
      [Token(Token = "0x600E04B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17001D51")]
    public int AddNum
    {
      [Token(Token = "0x600E04C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D52")]
    public string ItemIconPath
    {
      [Token(Token = "0x600E04D"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001D53")]
    public Sprite ItemFrameSprite
    {
      [Token(Token = "0x600E04E"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001D54")]
    public string ItemName
    {
      [Token(Token = "0x600E04F"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E050")]
    [Address(RVA = "0xAA40F0", Offset = "0xAA2EF0", VA = "0x10AA40F0")]
    public void Initialize(ItemParam itemParam, int addNum)
    {
    }

    [Token(Token = "0x600E051")]
    [Address(RVA = "0xAA4370", Offset = "0xAA3170", VA = "0x10AA4370")]
    private void SetEquipItemFrame(ItemParam itemParam)
    {
    }

    [Token(Token = "0x600E052")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArtiStoneEffect_ExchangeResultModel()
    {
    }
  }
}
