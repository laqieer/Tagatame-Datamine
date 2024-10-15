// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopGiftWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200238F")]
  [AddComponentMenu("UI/EventShopGiftWindow")]
  public class EventShopGiftWindow : MonoBehaviour
  {
    [Token(Token = "0x400A054")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemParent;
    [Token(Token = "0x400A055")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400A056")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text NavigationText;
    [Token(Token = "0x400A057")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> mItems;

    [Token(Token = "0x60099BA")]
    [Address(RVA = "0x5DF8C0", Offset = "0x5DE6C0", VA = "0x105DF8C0")]
    private void Start()
    {
    }

    [Token(Token = "0x60099BB")]
    [Address(RVA = "0x5DEED0", Offset = "0x5DDCD0", VA = "0x105DEED0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60099BC")]
    [Address(RVA = "0x5DF440", Offset = "0x5DE240", VA = "0x105DF440")]
    private void SetShowShopInfo(
      Json_ShopItemDesc purchased_item,
      Transform itemParent,
      int amount)
    {
    }

    [Token(Token = "0x60099BD")]
    public GameObject InstantiateItem<BindType>(
      GameObject template,
      Transform parent,
      BindType item)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60099BE")]
    [Address(RVA = "0x5DEA40", Offset = "0x5DD840", VA = "0x105DEA40")]
    private void RefreshCrystal(Transform itemParent)
    {
    }

    [Token(Token = "0x60099BF")]
    [Address(RVA = "0x5DF940", Offset = "0x5DE740", VA = "0x105DF940")]
    public EventShopGiftWindow()
    {
    }
  }
}
