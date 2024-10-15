// Decompiled with JetBrains decompiler
// Type: SRPG.ShopItemDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AA0")]
  [FlowNode.Pin(101, "Tap Unit", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(102, "Tap Artifact", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(103, "Tap ConceptCard", FlowNode.PinTypes.Input, 103)]
  [AddComponentMenu("UI/ShopItemDetail")]
  [FlowNode.Pin(10, "Finished", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(100, "Tap Item", FlowNode.PinTypes.Input, 100)]
  public class ShopItemDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CFC3")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x400CFC4")]
    private const int PIN_OUT_FINISHED = 10;
    [Token(Token = "0x400CFC5")]
    private const int PIN_IN_TAP_ITEM = 100;
    [Token(Token = "0x400CFC6")]
    private const int PIN_IN_TAP_UNIT = 101;
    [Token(Token = "0x400CFC7")]
    private const int PIN_IN_TAP_ARTIFACT = 102;
    [Token(Token = "0x400CFC8")]
    private const int PIN_IN_TAP_CONCEPTCARD = 103;
    [Token(Token = "0x400CFC9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemDetailWindow;
    [Token(Token = "0x400CFCA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ArtifactDetailWindow;
    [Token(Token = "0x400CFCB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ConceptCardDetail;
    [Token(Token = "0x400CFCC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Space(8f)]
    private GameObject ItemDetailPanel;
    [Token(Token = "0x400CFCD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform ItemHolder;
    [Token(Token = "0x400CFCE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400CFCF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject UnitTemplate;
    [Token(Token = "0x400CFD0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject ArtifactTemplate;
    [Token(Token = "0x400CFD1")]
    [FieldOffset(Offset = "0x2C")]
    [Space(8f)]
    [SerializeField]
    private GameObject ConceptCardDetailPanel;
    [Token(Token = "0x400CFD2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform ConceptCardHolder;
    [Token(Token = "0x400CFD3")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject ConceptCardTemplate;
    [Token(Token = "0x400CFD4")]
    [FieldOffset(Offset = "0x38")]
    private ShopItemDetail.TicketType mTicketType;

    [Token(Token = "0x600C2A6")]
    [Address(RVA = "0x8AE670", Offset = "0x8AD470", VA = "0x108AE670")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C2A7")]
    [Address(RVA = "0x8AE130", Offset = "0x8ACF30", VA = "0x108AE130", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C2A8")]
    [Address(RVA = "0x8AF830", Offset = "0x8AE630", VA = "0x108AF830")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C2A9")]
    [Address(RVA = "0x8AFB40", Offset = "0x8AE940", VA = "0x108AFB40")]
    private void UnitResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600C2AA")]
    [Address(RVA = "0x8AF300", Offset = "0x8AE100", VA = "0x108AF300")]
    private void ItemResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600C2AB")]
    [Address(RVA = "0x8AE510", Offset = "0x8AD310", VA = "0x108AE510")]
    private void ArtifactResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600C2AC")]
    [Address(RVA = "0x8AE820", Offset = "0x8AD620", VA = "0x108AE820")]
    private void ConceptCardResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600C2AD")]
    [Address(RVA = "0x8AF170", Offset = "0x8ADF70", VA = "0x108AF170")]
    private void CreateUnits(List<UnitSelectListItemData> units)
    {
    }

    [Token(Token = "0x600C2AE")]
    [Address(RVA = "0x8AEF50", Offset = "0x8ADD50", VA = "0x108AEF50")]
    private void CreateItems(List<ItemSelectListItemData> shopdata)
    {
    }

    [Token(Token = "0x600C2AF")]
    [Address(RVA = "0x8AEBE0", Offset = "0x8AD9E0", VA = "0x108AEBE0")]
    private void CreateArtifacts(List<ArtifactSelectListItemData> data)
    {
    }

    [Token(Token = "0x600C2B0")]
    [Address(RVA = "0x8AEDE0", Offset = "0x8ADBE0", VA = "0x108AEDE0")]
    private void CreateConceptCards(ConceptCardData[] data)
    {
    }

    [Token(Token = "0x600C2B1")]
    [Address(RVA = "0x8AF700", Offset = "0x8AE500", VA = "0x108AF700")]
    private void OnItemSelect()
    {
    }

    [Token(Token = "0x600C2B2")]
    [Address(RVA = "0x8AF460", Offset = "0x8AE260", VA = "0x108AF460")]
    private void OnArtifactSelect()
    {
    }

    [Token(Token = "0x600C2B3")]
    [Address(RVA = "0x8AF590", Offset = "0x8AE390", VA = "0x108AF590")]
    private void OnConceptCardSelect()
    {
    }

    [Token(Token = "0x600C2B4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopItemDetail()
    {
    }

    [Token(Token = "0x2002AA1")]
    private enum TicketType
    {
      [Token(Token = "0x400CFD6")] None,
      [Token(Token = "0x400CFD7")] Unit,
      [Token(Token = "0x400CFD8")] Item,
      [Token(Token = "0x400CFD9")] Artifact,
      [Token(Token = "0x400CFDA")] ConceptCard,
    }
  }
}
