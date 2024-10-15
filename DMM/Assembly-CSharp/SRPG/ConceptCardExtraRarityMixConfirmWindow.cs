// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardExtraRarityMixConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021CB")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "最終確認", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "初期化終了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "最終確認決定", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(111, "最終確認キャンセル", FlowNode.PinTypes.Output, 111)]
  public class ConceptCardExtraRarityMixConfirmWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x4009446")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x4009447")]
    private const int PIN_IN_CONFIRM = 2;
    [Token(Token = "0x4009448")]
    private const int PIN_OUT_INIT = 100;
    [Token(Token = "0x4009449")]
    private const int PIN_OUT_CONFIRM_DECIDE = 110;
    [Token(Token = "0x400944A")]
    private const int PIN_OUT_CONFIRM_CANCEL = 111;
    [Token(Token = "0x400944B")]
    public const string KEY_BASE_CARD_ID = "KEY_BASE_CARD_ID";
    [Token(Token = "0x400944C")]
    public const string KEY_MATERIAL_CARD_ID = "KEY_MATERIAL_CARD_ID";
    [Token(Token = "0x400944D")]
    public const string KEY_VIEW_COST = "KEY_VIEW_COST";
    [Token(Token = "0x400944E")]
    private const string UIUTILITY_CONFIRM_TITLE = "sys.CONCEPTCARD_EXTRA_RARITY_FINAL_CHECK_TITLE";
    [Token(Token = "0x400944F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private List<ExhibitList> confirmExhibitList;
    [Token(Token = "0x4009450")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentExhibit contentExhibit;
    [Token(Token = "0x4009451")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject CostViewRoot;
    [Token(Token = "0x4009452")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text CostText;
    [Token(Token = "0x4009453")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text ResultExtraRarityPointText;
    [Token(Token = "0x4009454")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text NeedExtraRaritypointText;
    [Token(Token = "0x4009455")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private float DelayTime;
    [Token(Token = "0x4009456")]
    [FieldOffset(Offset = "0x28")]
    private EnumBitArray<ConceptCardExtraRarityMixConfirmWindow.SelectedStatus> selected_status;
    [Token(Token = "0x4009457")]
    [FieldOffset(Offset = "0x2C")]
    private bool costShortage;

    [Token(Token = "0x6008EAE")]
    [Address(RVA = "0x530FB0", Offset = "0x52FDB0", VA = "0x10530FB0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6008EAF")]
    [Address(RVA = "0x530DD0", Offset = "0x52FBD0", VA = "0x10530DD0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008EB0")]
    [Address(RVA = "0x5312C0", Offset = "0x5300C0", VA = "0x105312C0")]
    private void Init()
    {
    }

    [Token(Token = "0x6008EB1")]
    [Address(RVA = "0x531340", Offset = "0x530140", VA = "0x10531340")]
    private void Init(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6008EB2")]
    [Address(RVA = "0x531A80", Offset = "0x530880", VA = "0x10531A80")]
    private void SetResultExtraRarityPoint(long card, IReadOnlyList<ConceptCardData> cards)
    {
    }

    [Token(Token = "0x6008EB3")]
    [Address(RVA = "0x531650", Offset = "0x530450", VA = "0x10531650")]
    private void SetConfirmStatus(IReadOnlyList<ConceptCardData> cards, long base_card)
    {
    }

    [Token(Token = "0x6008EB4")]
    [Address(RVA = "0x530FD0", Offset = "0x52FDD0", VA = "0x10530FD0")]
    private string GetConfirmText() => (string) null;

    [Token(Token = "0x6008EB5")]
    [Address(RVA = "0x531CC0", Offset = "0x530AC0", VA = "0x10531CC0")]
    public ConceptCardExtraRarityMixConfirmWindow()
    {
    }

    [Token(Token = "0x20021CC")]
    private enum SelectedStatus : byte
    {
      [Token(Token = "0x4009459")] None,
      [Token(Token = "0x400945A")] Equiped,
      [Token(Token = "0x400945B")] Favorite,
      [Token(Token = "0x400945C")] ExtraRarity,
      [Token(Token = "0x400945D")] OverSelected,
      [Token(Token = "0x400945E")] All,
    }
  }
}
