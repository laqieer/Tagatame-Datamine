// Decompiled with JetBrains decompiler
// Type: SRPG.ShopTimeOutItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AB4")]
  [AddComponentMenu("UI/ShopTimeOutItem")]
  public class ShopTimeOutItem : MonoBehaviour
  {
    [Token(Token = "0x400D053")]
    [FieldOffset(Offset = "0xC")]
    public Text Amount;
    [Token(Token = "0x400D054")]
    [FieldOffset(Offset = "0x10")]
    public Text Name;
    [Token(Token = "0x400D055")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemIcon;
    [Token(Token = "0x400D056")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactIcon;
    [Token(Token = "0x400D057")]
    [FieldOffset(Offset = "0x1C")]
    public ConceptCardIcon m_ConceptCardIcon;
    [Token(Token = "0x400D058")]
    [FieldOffset(Offset = "0x20")]
    public GameObject m_CrystalIcon;

    [Token(Token = "0x600C30E")]
    [Address(RVA = "0x8B7020", Offset = "0x8B5E20", VA = "0x108B7020")]
    public void SetShopItemInfo(ShopItem shop_item, string name)
    {
    }

    [Token(Token = "0x600C30F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopTimeOutItem()
    {
    }
  }
}
