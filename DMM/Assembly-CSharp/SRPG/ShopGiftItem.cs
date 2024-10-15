// Decompiled with JetBrains decompiler
// Type: SRPG.ShopGiftItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A9B")]
  [AddComponentMenu("UI/ShopGiftItem")]
  public class ShopGiftItem : MonoBehaviour
  {
    [Token(Token = "0x400CFB4")]
    [FieldOffset(Offset = "0xC")]
    public Text Amount;
    [Token(Token = "0x400CFB5")]
    [FieldOffset(Offset = "0x10")]
    public Text Name;
    [Token(Token = "0x400CFB6")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemIcon;
    [Token(Token = "0x400CFB7")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactIcon;
    [Token(Token = "0x400CFB8")]
    [FieldOffset(Offset = "0x1C")]
    public ConceptCardIcon m_ConceptCardIcon;
    [Token(Token = "0x400CFB9")]
    [FieldOffset(Offset = "0x20")]
    public CrystalIcon m_CrystalIcon;

    [Token(Token = "0x600C293")]
    [Address(RVA = "0x8ACD30", Offset = "0x8ABB30", VA = "0x108ACD30")]
    public void SetShopItemInfo(Json_ShopItemDesc shop_item_desc, string name, int amount)
    {
    }

    [Token(Token = "0x600C294")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopGiftItem()
    {
    }
  }
}
