// Decompiled with JetBrains decompiler
// Type: SRPG.ShopSetItemListElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AAF")]
  [FlowNode.Pin(0, "クリスタル設定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "クリスタル詳細作成", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/ShopSetItemListElement")]
  public class ShopSetItemListElement : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D01D")]
    private const int PIN_INPUT_SETCRYSTAL = 0;
    [Token(Token = "0x400D01E")]
    private const int PIN_OUTPUT_CREATE_CRYSTALDETAIL = 100;
    [Token(Token = "0x400D01F")]
    [FieldOffset(Offset = "0xC")]
    public Text itemName;
    [Token(Token = "0x400D020")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemIcon;
    [Token(Token = "0x400D021")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemDetailWindow;
    [Token(Token = "0x400D022")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactIcon;
    [Token(Token = "0x400D023")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ArtifactDetailWindow;
    [Token(Token = "0x400D024")]
    [FieldOffset(Offset = "0x20")]
    public GameObject ConceptCard;
    [Token(Token = "0x400D025")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ConceptCardDetailWindow;
    [Token(Token = "0x400D026")]
    [FieldOffset(Offset = "0x28")]
    public ShopBuyConfirmCrystal mCrystal;
    [Token(Token = "0x400D027")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mDetailWindow;
    [Token(Token = "0x400D028")]
    [FieldOffset(Offset = "0x30")]
    private ShopItem mShopItem;
    [Token(Token = "0x400D029")]
    [FieldOffset(Offset = "0x34")]
    private ItemData mItemData;
    [Token(Token = "0x400D02A")]
    [FieldOffset(Offset = "0x38")]
    private ArtifactParam mArtifactParam;
    [Token(Token = "0x400D02B")]
    [FieldOffset(Offset = "0x3C")]
    private ConceptCardData mConceptCardData;
    [Token(Token = "0x400D02C")]
    [FieldOffset(Offset = "0x40")]
    private CrystalData mCrystalData;
    [Token(Token = "0x400D02D")]
    [FieldOffset(Offset = "0x44")]
    private CrystalParam mCrystalParam;

    [Token(Token = "0x170019F9")]
    public ItemData itemData
    {
      [Token(Token = "0x600C2F3"), Address(RVA = "0x8B5CE0", Offset = "0x8B4AE0", VA = "0x108B5CE0")] set
      {
      }
      [Token(Token = "0x600C2F4"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x170019FA")]
    public ArtifactParam ArtifactParam
    {
      [Token(Token = "0x600C2F5"), Address(RVA = "0x8B5C80", Offset = "0x8B4A80", VA = "0x108B5C80")] set
      {
      }
      [Token(Token = "0x600C2F6"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (ArtifactParam) null;
      }
    }

    [Token(Token = "0x600C2F7")]
    [Address(RVA = "0x8B5500", Offset = "0x8B4300", VA = "0x108B5500", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C2F8")]
    [Address(RVA = "0x8B5AE0", Offset = "0x8B48E0", VA = "0x108B5AE0")]
    public void SetupConceptCard(ConceptCardData conceptCardData)
    {
    }

    [Token(Token = "0x600C2F9")]
    [Address(RVA = "0x8B5BD0", Offset = "0x8B49D0", VA = "0x108B5BD0")]
    public void SetupCrystal(CrystalData _data, CrystalParam _param)
    {
    }

    [Token(Token = "0x600C2FA")]
    [Address(RVA = "0x8B5940", Offset = "0x8B4740", VA = "0x108B5940")]
    public void SetShopItemDesc(Json_ShopItemDesc item)
    {
    }

    [Token(Token = "0x600C2FB")]
    [Address(RVA = "0x8B55B0", Offset = "0x8B43B0", VA = "0x108B55B0")]
    public void OnClickDetailArtifact()
    {
    }

    [Token(Token = "0x600C2FC")]
    [Address(RVA = "0x8B57E0", Offset = "0x8B45E0", VA = "0x108B57E0")]
    public void OnClickDetailItem()
    {
    }

    [Token(Token = "0x600C2FD")]
    [Address(RVA = "0x8B56F0", Offset = "0x8B44F0", VA = "0x108B56F0")]
    public void OnClickDetailConceptCard()
    {
    }

    [Token(Token = "0x600C2FE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopSetItemListElement()
    {
    }
  }
}
