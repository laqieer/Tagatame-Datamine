// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopItemDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026D4")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Tap Item", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "Tap Unit", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(102, "Tap Artifact", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(103, "Tap ConceptCard", FlowNode.PinTypes.Input, 103)]
  [FlowNode.Pin(10, "Finished", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/LimitedShopItemDetail")]
  public class LimitedShopItemDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B675")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x400B676")]
    private const int PIN_OUT_FINISHED = 10;
    [Token(Token = "0x400B677")]
    private const int PIN_IN_TAP_ITEM = 100;
    [Token(Token = "0x400B678")]
    private const int PIN_IN_TAP_UNIT = 101;
    [Token(Token = "0x400B679")]
    private const int PIN_IN_TAP_ARTIFACT = 102;
    [Token(Token = "0x400B67A")]
    private const int PIN_IN_TAP_CONCEPTCARD = 103;
    [Token(Token = "0x400B67B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemDetailWindow;
    [Token(Token = "0x400B67C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ArtifactDetailWindow;
    [Token(Token = "0x400B67D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ConceptCardDetail;
    [Token(Token = "0x400B67E")]
    [FieldOffset(Offset = "0x18")]
    [Space(8f)]
    [SerializeField]
    private GameObject ItemDetailPanel;
    [Token(Token = "0x400B67F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform ItemHolder;
    [Token(Token = "0x400B680")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400B681")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject UnitTemplate;
    [Token(Token = "0x400B682")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject ArtifactTemplate;
    [Token(Token = "0x400B683")]
    [FieldOffset(Offset = "0x2C")]
    [Space(8f)]
    [SerializeField]
    private GameObject ConceptCardDetailPanel;
    [Token(Token = "0x400B684")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform ConceptCardHolder;
    [Token(Token = "0x400B685")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject ConceptCardTemplate;
    [Token(Token = "0x400B686")]
    [FieldOffset(Offset = "0x38")]
    private LimitedShopItemDetail.TicketType mTicketType;

    [Token(Token = "0x600ADD4")]
    [Address(RVA = "0x71C390", Offset = "0x71B190", VA = "0x1071C390")]
    private void Awake()
    {
    }

    [Token(Token = "0x600ADD5")]
    [Address(RVA = "0x71BE50", Offset = "0x71AC50", VA = "0x1071BE50", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ADD6")]
    [Address(RVA = "0x71D550", Offset = "0x71C350", VA = "0x1071D550")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600ADD7")]
    [Address(RVA = "0x71D860", Offset = "0x71C660", VA = "0x1071D860")]
    private void UnitResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600ADD8")]
    [Address(RVA = "0x71D020", Offset = "0x71BE20", VA = "0x1071D020")]
    private void ItemResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600ADD9")]
    [Address(RVA = "0x71C230", Offset = "0x71B030", VA = "0x1071C230")]
    private void ArtifactResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600ADDA")]
    [Address(RVA = "0x71C540", Offset = "0x71B340", VA = "0x1071C540")]
    private void ConceptCardResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600ADDB")]
    [Address(RVA = "0x71CE90", Offset = "0x71BC90", VA = "0x1071CE90")]
    private void CreateUnits(List<UnitSelectListItemData> units)
    {
    }

    [Token(Token = "0x600ADDC")]
    [Address(RVA = "0x71CC70", Offset = "0x71BA70", VA = "0x1071CC70")]
    private void CreateItems(List<ItemSelectListItemData> shopdata)
    {
    }

    [Token(Token = "0x600ADDD")]
    [Address(RVA = "0x71C900", Offset = "0x71B700", VA = "0x1071C900")]
    private void CreateArtifacts(List<ArtifactSelectListItemData> data)
    {
    }

    [Token(Token = "0x600ADDE")]
    [Address(RVA = "0x71CB00", Offset = "0x71B900", VA = "0x1071CB00")]
    private void CreateConceptCards(ConceptCardData[] data)
    {
    }

    [Token(Token = "0x600ADDF")]
    [Address(RVA = "0x71D420", Offset = "0x71C220", VA = "0x1071D420")]
    private void OnItemSelect()
    {
    }

    [Token(Token = "0x600ADE0")]
    [Address(RVA = "0x71D180", Offset = "0x71BF80", VA = "0x1071D180")]
    private void OnArtifactSelect()
    {
    }

    [Token(Token = "0x600ADE1")]
    [Address(RVA = "0x71D2B0", Offset = "0x71C0B0", VA = "0x1071D2B0")]
    private void OnConceptCardSelect()
    {
    }

    [Token(Token = "0x600ADE2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LimitedShopItemDetail()
    {
    }

    [Token(Token = "0x20026D5")]
    private enum TicketType
    {
      [Token(Token = "0x400B688")] None,
      [Token(Token = "0x400B689")] Unit,
      [Token(Token = "0x400B68A")] Item,
      [Token(Token = "0x400B68B")] Artifact,
      [Token(Token = "0x400B68C")] ConceptCard,
    }
  }
}
