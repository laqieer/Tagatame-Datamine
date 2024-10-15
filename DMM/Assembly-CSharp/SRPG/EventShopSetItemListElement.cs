// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopSetItemListElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002399")]
  [FlowNode.Pin(0, "クリスタル設定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "クリスタル詳細作成", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/EventShopSetItemListElement")]
  public class EventShopSetItemListElement : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A07C")]
    private const int PIN_INPUT_SETCRYSTAL = 0;
    [Token(Token = "0x400A07D")]
    private const int PIN_OUTPUT_CREATE_CRYSTALDETAIL = 100;
    [Token(Token = "0x400A07E")]
    [FieldOffset(Offset = "0xC")]
    public Text itemName;
    [Token(Token = "0x400A07F")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemIcon;
    [Token(Token = "0x400A080")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemDetailWindow;
    [Token(Token = "0x400A081")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactIcon;
    [Token(Token = "0x400A082")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ArtifactDetailWindow;
    [Token(Token = "0x400A083")]
    [FieldOffset(Offset = "0x20")]
    public GameObject ConceptCard;
    [Token(Token = "0x400A084")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ConceptCardDetailWindow;
    [Token(Token = "0x400A085")]
    [FieldOffset(Offset = "0x28")]
    public ShopBuyConfirmCrystal mCrystal;
    [Token(Token = "0x400A086")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mDetailWindow;
    [Token(Token = "0x400A087")]
    [FieldOffset(Offset = "0x30")]
    private EventShopItem mShopItem;
    [Token(Token = "0x400A088")]
    [FieldOffset(Offset = "0x34")]
    private ItemData mItemData;
    [Token(Token = "0x400A089")]
    [FieldOffset(Offset = "0x38")]
    private ArtifactParam mArtifactParam;
    [Token(Token = "0x400A08A")]
    [FieldOffset(Offset = "0x3C")]
    private ConceptCardData mConceptCardData;
    [Token(Token = "0x400A08B")]
    [FieldOffset(Offset = "0x40")]
    private CrystalData mCrystalData;
    [Token(Token = "0x400A08C")]
    [FieldOffset(Offset = "0x44")]
    private CrystalParam mCrystalParam;

    [Token(Token = "0x17001561")]
    public ItemData itemData
    {
      [Token(Token = "0x60099DE"), Address(RVA = "0x5E2CF0", Offset = "0x5E1AF0", VA = "0x105E2CF0")] set
      {
      }
      [Token(Token = "0x60099DF"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17001562")]
    public ArtifactParam ArtifactParam
    {
      [Token(Token = "0x60099E0"), Address(RVA = "0x5E2C90", Offset = "0x5E1A90", VA = "0x105E2C90")] set
      {
      }
      [Token(Token = "0x60099E1"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (ArtifactParam) null;
      }
    }

    [Token(Token = "0x60099E2")]
    [Address(RVA = "0x5E2510", Offset = "0x5E1310", VA = "0x105E2510", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60099E3")]
    [Address(RVA = "0x5E2AF0", Offset = "0x5E18F0", VA = "0x105E2AF0")]
    public void SetupConceptCard(ConceptCardData conceptCardData)
    {
    }

    [Token(Token = "0x60099E4")]
    [Address(RVA = "0x5E2BE0", Offset = "0x5E19E0", VA = "0x105E2BE0")]
    public void SetupCrystal(CrystalData _data, CrystalParam _param)
    {
    }

    [Token(Token = "0x60099E5")]
    [Address(RVA = "0x5E2950", Offset = "0x5E1750", VA = "0x105E2950")]
    public void SetShopItemDesc(Json_ShopItemDesc item)
    {
    }

    [Token(Token = "0x60099E6")]
    [Address(RVA = "0x5E25C0", Offset = "0x5E13C0", VA = "0x105E25C0")]
    public void OnClickDetailArtifact()
    {
    }

    [Token(Token = "0x60099E7")]
    [Address(RVA = "0x5E27F0", Offset = "0x5E15F0", VA = "0x105E27F0")]
    public void OnClickDetailItem()
    {
    }

    [Token(Token = "0x60099E8")]
    [Address(RVA = "0x5E2700", Offset = "0x5E1500", VA = "0x105E2700")]
    public void OnClickDetailConceptCard()
    {
    }

    [Token(Token = "0x60099E9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public EventShopSetItemListElement()
    {
    }
  }
}
