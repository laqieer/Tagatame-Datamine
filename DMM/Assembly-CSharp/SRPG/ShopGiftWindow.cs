// Decompiled with JetBrains decompiler
// Type: SRPG.ShopGiftWindow
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
  [Token(Token = "0x2002A9C")]
  [AddComponentMenu("UI/ShopGiftWindow")]
  public class ShopGiftWindow : MonoBehaviour
  {
    [Token(Token = "0x400CFBA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemParent;
    [Token(Token = "0x400CFBB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400CFBC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text NavigationText;
    [Token(Token = "0x400CFBD")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> mItems;

    [Token(Token = "0x600C295")]
    [Address(RVA = "0x8ADE60", Offset = "0x8ACC60", VA = "0x108ADE60")]
    private void Start()
    {
    }

    [Token(Token = "0x600C296")]
    [Address(RVA = "0x8AD450", Offset = "0x8AC250", VA = "0x108AD450")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C297")]
    [Address(RVA = "0x8AD9E0", Offset = "0x8AC7E0", VA = "0x108AD9E0")]
    private void SetShowShopInfo(
      Json_ShopItemDesc purchased_item,
      Transform itemParent,
      int amount)
    {
    }

    [Token(Token = "0x600C298")]
    public GameObject InstantiateItem<BindType>(
      GameObject template,
      Transform parent,
      BindType item)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600C299")]
    [Address(RVA = "0x8ACFC0", Offset = "0x8ABDC0", VA = "0x108ACFC0")]
    private void RefreshCrystal(Transform itemParent)
    {
    }

    [Token(Token = "0x600C29A")]
    [Address(RVA = "0x8ADEE0", Offset = "0x8ACCE0", VA = "0x108ADEE0")]
    public ShopGiftWindow()
    {
    }
  }
}
