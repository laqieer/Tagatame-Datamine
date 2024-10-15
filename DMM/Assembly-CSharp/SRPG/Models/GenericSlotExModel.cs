// Decompiled with JetBrains decompiler
// Type: SRPG.Models.GenericSlotExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200334A")]
  public class GenericSlotExModel
  {
    [Token(Token = "0x400F205")]
    private const int EmptySlotNum = -1;
    [Token(Token = "0x400F206")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsHideMode;
    [Token(Token = "0x400F207")]
    [FieldOffset(Offset = "0xC")]
    private Color mMainGraphicColor;
    [Token(Token = "0x400F208")]
    [FieldOffset(Offset = "0x1C")]
    private Sprite mBGImageSprite;
    [Token(Token = "0x400F209")]
    [FieldOffset(Offset = "0x20")]
    private Sprite mEmptyBG;
    [Token(Token = "0x400F20A")]
    [FieldOffset(Offset = "0x24")]
    private Sprite mNonEmptyBG;
    [Token(Token = "0x400F20B")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<GenericSlotFlags.VisibleFlags, bool> mVisibleFlagDic;
    [Token(Token = "0x400F20C")]
    [FieldOffset(Offset = "0x2C")]
    private bool mSelectButtonInteractable;
    [Token(Token = "0x400F20D")]
    [FieldOffset(Offset = "0x2D")]
    private bool mIsNullData;
    [Token(Token = "0x400F20E")]
    [FieldOffset(Offset = "0x30")]
    private int mSlotNum;

    [Token(Token = "0x17001E5C")]
    public bool IsHideMode
    {
      [Token(Token = "0x600E2E0"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E5D")]
    public Color MainGraphicColor
    {
      [Token(Token = "0x600E2E1"), Address(RVA = "0x2AD1E0", Offset = "0x2ABFE0", VA = "0x102AD1E0")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x17001E5E")]
    public Sprite BGImageSprite
    {
      [Token(Token = "0x600E2E2"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001E5F")]
    public bool SelectButtonInteractable
    {
      [Token(Token = "0x600E2E3"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E60")]
    public bool IsNullData
    {
      [Token(Token = "0x600E2E4"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E61")]
    public int SlotNum
    {
      [Token(Token = "0x600E2E5"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E2E6")]
    [Address(RVA = "0xAB1D50", Offset = "0xAB0B50", VA = "0x10AB1D50")]
    public GenericSlotExModel(Sprite emptyBG, Sprite nonEmptyBG, int slotIndex, bool isHide = false)
    {
    }

    [Token(Token = "0x600E2E7")]
    [Address(RVA = "0x373930", Offset = "0x372730", VA = "0x10373930")]
    public void SetSlotNum(int slotIndex = -1)
    {
    }

    [Token(Token = "0x600E2E8")]
    [Address(RVA = "0xAB1B80", Offset = "0xAB0980", VA = "0x10AB1B80")]
    public bool IsVisible(GenericSlotFlags.VisibleFlags key, GenericSlotFlags subItem)
    {
      return new bool();
    }

    [Token(Token = "0x600E2E9")]
    public void Initialize<T>(T data)
    {
    }

    [Token(Token = "0x600E2EA")]
    [Address(RVA = "0xAB18B0", Offset = "0xAB06B0", VA = "0x10AB18B0")]
    public void InitializeVisibleFlagDictionary()
    {
    }

    [Token(Token = "0x600E2EB")]
    [Address(RVA = "0x2AD200", Offset = "0x2AC000", VA = "0x102AD200")]
    public void SetMainColor(Color color)
    {
    }

    [Token(Token = "0x600E2EC")]
    [Address(RVA = "0xAB1C20", Offset = "0xAB0A20", VA = "0x10AB1C20")]
    public void SetLocked(bool locked)
    {
    }

    [Token(Token = "0x600E2ED")]
    [Address(RVA = "0xAB1BE0", Offset = "0xAB09E0", VA = "0x10AB1BE0")]
    public void SetBGImage(bool slotEmpty)
    {
    }

    [Token(Token = "0x600E2EE")]
    [Address(RVA = "0xAB1CA0", Offset = "0xAB0AA0", VA = "0x10AB1CA0")]
    public void SetVisibleEmpty(bool slotEmpty)
    {
    }
  }
}
