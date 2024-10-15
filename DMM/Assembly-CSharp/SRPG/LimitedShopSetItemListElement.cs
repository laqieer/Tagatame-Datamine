// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopSetItemListElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026D9")]
  [FlowNode.Pin(0, "クリスタル設定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "クリスタル詳細作成", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/LimitedShopSetItemListElement")]
  public class LimitedShopSetItemListElement : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B69A")]
    private const int PIN_INPUT_SETCRYSTAL = 0;
    [Token(Token = "0x400B69B")]
    private const int PIN_OUTPUT_CREATE_CRYSTALDETAIL = 100;
    [Token(Token = "0x400B69C")]
    [FieldOffset(Offset = "0xC")]
    public Text itemName;
    [Token(Token = "0x400B69D")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemIcon;
    [Token(Token = "0x400B69E")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemDetailWindow;
    [Token(Token = "0x400B69F")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArtifactIcon;
    [Token(Token = "0x400B6A0")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject ArtifactDetailWindow;
    [Token(Token = "0x400B6A1")]
    [FieldOffset(Offset = "0x20")]
    public GameObject ConceptCard;
    [Token(Token = "0x400B6A2")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ConceptCardDetailWindow;
    [Token(Token = "0x400B6A3")]
    [FieldOffset(Offset = "0x28")]
    public ShopBuyConfirmCrystal mCrystal;
    [Token(Token = "0x400B6A4")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mDetailWindow;
    [Token(Token = "0x400B6A5")]
    [FieldOffset(Offset = "0x30")]
    private LimitedShopItem mLimitedShopItem;
    [Token(Token = "0x400B6A6")]
    [FieldOffset(Offset = "0x34")]
    private ItemData mItemData;
    [Token(Token = "0x400B6A7")]
    [FieldOffset(Offset = "0x38")]
    private ArtifactParam mArtifactParam;
    [Token(Token = "0x400B6A8")]
    [FieldOffset(Offset = "0x3C")]
    private ConceptCardData mConceptCardData;
    [Token(Token = "0x400B6A9")]
    [FieldOffset(Offset = "0x40")]
    private CrystalData mCrystalData;
    [Token(Token = "0x400B6AA")]
    [FieldOffset(Offset = "0x44")]
    private CrystalParam mCrystalParam;

    [Token(Token = "0x17001813")]
    public ItemData itemData
    {
      [Token(Token = "0x600ADEF"), Address(RVA = "0x71FC80", Offset = "0x71EA80", VA = "0x1071FC80")] set
      {
      }
      [Token(Token = "0x600ADF0"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17001814")]
    public ArtifactParam ArtifactParam
    {
      [Token(Token = "0x600ADF1"), Address(RVA = "0x71FC20", Offset = "0x71EA20", VA = "0x1071FC20")] set
      {
      }
      [Token(Token = "0x600ADF2"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (ArtifactParam) null;
      }
    }

    [Token(Token = "0x600ADF3")]
    [Address(RVA = "0x71F4A0", Offset = "0x71E2A0", VA = "0x1071F4A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ADF4")]
    [Address(RVA = "0x71FA80", Offset = "0x71E880", VA = "0x1071FA80")]
    public void SetupConceptCard(ConceptCardData conceptCardData)
    {
    }

    [Token(Token = "0x600ADF5")]
    [Address(RVA = "0x71FB70", Offset = "0x71E970", VA = "0x1071FB70")]
    public void SetupCrystal(CrystalData _data, CrystalParam _param)
    {
    }

    [Token(Token = "0x600ADF6")]
    [Address(RVA = "0x71F8E0", Offset = "0x71E6E0", VA = "0x1071F8E0")]
    public void SetShopItemDesc(Json_ShopItemDesc item)
    {
    }

    [Token(Token = "0x600ADF7")]
    [Address(RVA = "0x71F550", Offset = "0x71E350", VA = "0x1071F550")]
    public void OnClickDetailArtifact()
    {
    }

    [Token(Token = "0x600ADF8")]
    [Address(RVA = "0x71F780", Offset = "0x71E580", VA = "0x1071F780")]
    public void OnClickDetailItem()
    {
    }

    [Token(Token = "0x600ADF9")]
    [Address(RVA = "0x71F690", Offset = "0x71E490", VA = "0x1071F690")]
    public void OnClickDetailConceptCard()
    {
    }

    [Token(Token = "0x600ADFA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LimitedShopSetItemListElement()
    {
    }
  }
}
