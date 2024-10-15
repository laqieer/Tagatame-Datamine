// Decompiled with JetBrains decompiler
// Type: SRPG.ShopBuyList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A90")]
  [AddComponentMenu("UI/ShopBuyList")]
  public class ShopBuyList : MonoBehaviour, IWebHelp
  {
    [Token(Token = "0x400CF2F")]
    [FieldOffset(Offset = "0xC")]
    public GameObject amount;
    [Token(Token = "0x400CF30")]
    [FieldOffset(Offset = "0x10")]
    public GameObject day_reset;
    [Token(Token = "0x400CF31")]
    [FieldOffset(Offset = "0x14")]
    public GameObject limit;
    [Token(Token = "0x400CF32")]
    [FieldOffset(Offset = "0x18")]
    public GameObject icon_set;
    [Token(Token = "0x400CF33")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject sold_count;
    [Token(Token = "0x400CF34")]
    [FieldOffset(Offset = "0x20")]
    public GameObject no_limited_price;
    [Token(Token = "0x400CF35")]
    [FieldOffset(Offset = "0x24")]
    public Text amount_text;
    [Token(Token = "0x400CF36")]
    [FieldOffset(Offset = "0x28")]
    public GameObject discount_low;
    [Token(Token = "0x400CF37")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject discount_middle;
    [Token(Token = "0x400CF38")]
    [FieldOffset(Offset = "0x30")]
    public GameObject discount_high;
    [Token(Token = "0x400CF39")]
    [FieldOffset(Offset = "0x34")]
    public GameObject image_price_sold_count;
    [Token(Token = "0x400CF3A")]
    [FieldOffset(Offset = "0x38")]
    public GameObject image_price_sold_count_infinite;
    [Token(Token = "0x400CF3B")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject unit_have_purchase;
    [Token(Token = "0x400CF3C")]
    [FieldOffset(Offset = "0x40")]
    [HeaderBar("▼アイテム表示用")]
    public GameObject item_name;
    [Token(Token = "0x400CF3D")]
    [FieldOffset(Offset = "0x44")]
    public GameObject item_icon;
    [Token(Token = "0x400CF3E")]
    [FieldOffset(Offset = "0x48")]
    [HeaderBar("▼武具表示用")]
    public GameObject artifact_name;
    [Token(Token = "0x400CF3F")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject artifact_icon;
    [Token(Token = "0x400CF40")]
    [FieldOffset(Offset = "0x50")]
    [HeaderBar("▼真理念装表示用")]
    public GameObject conceptCard_name;
    [Token(Token = "0x400CF41")]
    [FieldOffset(Offset = "0x54")]
    public ConceptCardIcon conceptCard_icon;
    [Token(Token = "0x400CF42")]
    [FieldOffset(Offset = "0x58")]
    [HeaderBar("▼水晶表示用")]
    public Text crystal_name;
    [Token(Token = "0x400CF43")]
    [FieldOffset(Offset = "0x5C")]
    public CrystalIcon crystal_icon;
    [Token(Token = "0x400CF44")]
    [FieldOffset(Offset = "0x60")]
    public GameObject crystalHelp;
    [Token(Token = "0x400CF45")]
    [FieldOffset(Offset = "0x64")]
    private string crystalWebID;
    [Token(Token = "0x400CF46")]
    [FieldOffset(Offset = "0x68")]
    private ShopItem mShopItem;

    [Token(Token = "0x170019F5")]
    public ShopItem ShopItem
    {
      [Token(Token = "0x600C25A"), Address(RVA = "0x8A8D70", Offset = "0x8A7B70", VA = "0x108A8D70")] set
      {
      }
      [Token(Token = "0x600C25B"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return (ShopItem) null;
      }
    }

    [Token(Token = "0x600C25C")]
    [Address(RVA = "0x8A8A30", Offset = "0x8A7830", VA = "0x108A8A30")]
    public void SetupDiscountUI()
    {
    }

    [Token(Token = "0x600C25D")]
    [Address(RVA = "0x8A88D0", Offset = "0x8A76D0", VA = "0x108A88D0")]
    public void SetupConceptCard(ConceptCardData conceptCardData)
    {
    }

    [Token(Token = "0x600C25E")]
    [Address(RVA = "0x8A8940", Offset = "0x8A7740", VA = "0x108A8940")]
    public void SetupCrystal(CrystalData _data, CrystalParam _param, string webId)
    {
    }

    [Token(Token = "0x600C25F")]
    [Address(RVA = "0x8A8C80", Offset = "0x8A7A80", VA = "0x108A8C80")]
    public void SetupWebURL(string webId)
    {
    }

    [Token(Token = "0x600C260")]
    [Address(RVA = "0x8A8820", Offset = "0x8A7620", VA = "0x108A8820", Slot = "4")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600C261")]
    [Address(RVA = "0x8A8D20", Offset = "0x8A7B20", VA = "0x108A8D20")]
    public ShopBuyList()
    {
    }

    [Token(Token = "0x2002A91")]
    public enum DiscountGrade : byte
    {
      [Token(Token = "0x400CF48")] None,
      [Token(Token = "0x400CF49")] Low,
      [Token(Token = "0x400CF4A")] Middle,
      [Token(Token = "0x400CF4B")] High,
    }
  }
}
