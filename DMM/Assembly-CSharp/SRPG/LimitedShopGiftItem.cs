﻿// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopGiftItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026D0")]
  [AddComponentMenu("UI/LimitedShopGiftItem")]
  public class LimitedShopGiftItem : MonoBehaviour
  {
    [Token(Token = "0x400B669")]
    [FieldOffset(Offset = "0xC")]
    public Text Amount;
    [Token(Token = "0x400B66A")]
    [FieldOffset(Offset = "0x10")]
    public Text Name;
    [Token(Token = "0x400B66B")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemIcon;
    [Token(Token = "0x400B66C")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactIcon;
    [Token(Token = "0x400B66D")]
    [FieldOffset(Offset = "0x1C")]
    public ConceptCardIcon m_ConceptCardIcon;
    [Token(Token = "0x400B66E")]
    [FieldOffset(Offset = "0x20")]
    public CrystalIcon m_CrystalIcon;

    [Token(Token = "0x600ADC8")]
    [Address(RVA = "0x71ACF0", Offset = "0x719AF0", VA = "0x1071ACF0")]
    public void SetShopItemInfo(Json_ShopItemDesc shop_item_desc, string name, int amount)
    {
    }

    [Token(Token = "0x600ADC9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LimitedShopGiftItem()
    {
    }
  }
}