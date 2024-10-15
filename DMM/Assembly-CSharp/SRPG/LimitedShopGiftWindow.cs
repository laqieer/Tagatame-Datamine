// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopGiftWindow
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
  [Token(Token = "0x20026D1")]
  [AddComponentMenu("UI/LimitedShopGiftWindow")]
  public class LimitedShopGiftWindow : MonoBehaviour
  {
    [Token(Token = "0x400B66F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemParent;
    [Token(Token = "0x400B670")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400B671")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text NavigationText;
    [Token(Token = "0x400B672")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> mItems;

    [Token(Token = "0x600ADCA")]
    [Address(RVA = "0x71BD60", Offset = "0x71AB60", VA = "0x1071BD60")]
    private void Start()
    {
    }

    [Token(Token = "0x600ADCB")]
    [Address(RVA = "0x71B370", Offset = "0x71A170", VA = "0x1071B370")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600ADCC")]
    [Address(RVA = "0x71B8E0", Offset = "0x71A6E0", VA = "0x1071B8E0")]
    private void SetShowShopInfo(
      Json_ShopItemDesc purchased_item,
      Transform itemParent,
      int amount)
    {
    }

    [Token(Token = "0x600ADCD")]
    public GameObject InstantiateItem<BindType>(
      GameObject template,
      Transform parent,
      BindType item)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600ADCE")]
    [Address(RVA = "0x71AEF0", Offset = "0x719CF0", VA = "0x1071AEF0")]
    private void RefreshCrystal(Transform itemParent)
    {
    }

    [Token(Token = "0x600ADCF")]
    [Address(RVA = "0x71BDE0", Offset = "0x71ABE0", VA = "0x1071BDE0")]
    public LimitedShopGiftWindow()
    {
    }
  }
}
