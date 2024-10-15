// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopGiftItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200238E")]
  [AddComponentMenu("UI/EventShopGiftItem")]
  public class EventShopGiftItem : MonoBehaviour
  {
    [Token(Token = "0x400A04E")]
    [FieldOffset(Offset = "0xC")]
    public Text Amount;
    [Token(Token = "0x400A04F")]
    [FieldOffset(Offset = "0x10")]
    public Text Name;
    [Token(Token = "0x400A050")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemIcon;
    [Token(Token = "0x400A051")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactIcon;
    [Token(Token = "0x400A052")]
    [FieldOffset(Offset = "0x1C")]
    public ConceptCardIcon m_ConceptCardIcon;
    [Token(Token = "0x400A053")]
    [FieldOffset(Offset = "0x20")]
    public CrystalIcon m_CrystalIcon;

    [Token(Token = "0x60099B8")]
    [Address(RVA = "0x5DE840", Offset = "0x5DD640", VA = "0x105DE840")]
    public void SetShopItemInfo(Json_ShopItemDesc shop_item_desc, string name, int amount)
    {
    }

    [Token(Token = "0x60099B9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventShopGiftItem()
    {
    }
  }
}
