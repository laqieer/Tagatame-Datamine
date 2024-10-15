// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceEventSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F45")]
  [FlowNode.Pin(101, "セレクトした", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "ホームへ戻る", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "イベントアーカイブへ戻る", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(111, "バナーがひとつもなかった", FlowNode.PinTypes.Output, 111)]
  [AddComponentMenu("UI/Advance/AdvanceEventSelector")]
  [FlowNode.Pin(2, "戻るボタン", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "セレクト開始", FlowNode.PinTypes.Input, 1)]
  public class AdvanceEventSelector : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40083AC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x40083AD")]
    [FieldOffset(Offset = "0x10")]
    [Space(5f)]
    [SerializeField]
    private SRPG_ScrollRect ScrollRectController;
    [Token(Token = "0x40083AE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoSelParent;
    [Token(Token = "0x40083AF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AdvanceEventSelectorItem SelBaseItem;
    [Token(Token = "0x40083B0")]
    [FieldOffset(Offset = "0x1C")]
    [Space(5f)]
    [SerializeField]
    private bool IsSortUpper;
    [Token(Token = "0x40083B1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Space(5f)]
    private GameObject NoItem;
    [Token(Token = "0x40083B2")]
    [FieldOffset(Offset = "0x24")]
    [Space(5f)]
    [Header("スクロール位置を再計算する")]
    [SerializeField]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x40083B3")]
    [FieldOffset(Offset = "0x28")]
    private float BITING_PREVENT_VELOCITY;
    [Token(Token = "0x40083B4")]
    private const int PIN_IN_START = 1;
    [Token(Token = "0x40083B5")]
    private const int PIN_IN_BUTTON_BACK = 2;
    [Token(Token = "0x40083B6")]
    private const int PIN_OUT_SELECTED = 101;
    [Token(Token = "0x40083B7")]
    private const int PIN_OUT_BACK_TO_HOME = 102;
    [Token(Token = "0x40083B8")]
    private const int PIN_OUT_BACK_TO_ARCHIVE = 103;
    [Token(Token = "0x40083B9")]
    private const int PIN_OUT_NOTHING_BANNER = 111;
    [Token(Token = "0x40083BA")]
    [FieldOffset(Offset = "0x2C")]
    private List<ChapterParam> mChapterParams;
    [Token(Token = "0x40083BB")]
    [FieldOffset(Offset = "0x30")]
    private List<AdvanceEventParam> mAdEvParams;
    [Token(Token = "0x40083BC")]
    [FieldOffset(Offset = "0x34")]
    private List<AdvanceEventSelectorItem> mAdEvSelectorItems;
    [Token(Token = "0x40083BD")]
    [FieldOffset(Offset = "0x38")]
    private Transform mSelectItemParent;

    [Token(Token = "0x6008031")]
    [Address(RVA = "0x409900", Offset = "0x408700", VA = "0x10409900")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008032")]
    [Address(RVA = "0x40A230", Offset = "0x409030", VA = "0x1040A230")]
    private void Init()
    {
    }

    [Token(Token = "0x6008033")]
    [Address(RVA = "0x409950", Offset = "0x408750", VA = "0x10409950")]
    private void CreateAdvanceEventList(ChapterParam current_chapter)
    {
    }

    [Token(Token = "0x6008034")]
    [Address(RVA = "0x40AED0", Offset = "0x409CD0", VA = "0x1040AED0")]
    private void SetScrollPos()
    {
    }

    [Token(Token = "0x6008035")]
    [Address(RVA = "0x40A1B0", Offset = "0x408FB0", VA = "0x1040A1B0")]
    private IEnumerator InitScroll(Vector2 vector) => (IEnumerator) null;

    [Token(Token = "0x6008036")]
    [Address(RVA = "0x40AD70", Offset = "0x409B70", VA = "0x1040AD70")]
    public void OnSelectItem(AdvanceEventSelectorItem item)
    {
    }

    [Token(Token = "0x6008037")]
    [Address(RVA = "0x40AA30", Offset = "0x409830", VA = "0x1040AA30")]
    public static bool IsDateUnlock(ChapterParam chapter, long t) => new bool();

    [Token(Token = "0x6008038")]
    [Address(RVA = "0x40A8A0", Offset = "0x4096A0", VA = "0x1040A8A0")]
    public static bool IsChapterQuestCond(ChapterParam chapter) => new bool();

    [Token(Token = "0x6008039")]
    [Address(RVA = "0x40ABD0", Offset = "0x4099D0", VA = "0x1040ABD0")]
    public static bool IsKeyUnlock(ChapterParam chapter, long t) => new bool();

    [Token(Token = "0x600803A")]
    [Address(RVA = "0x409740", Offset = "0x408540", VA = "0x10409740", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600803B")]
    [Address(RVA = "0x40B230", Offset = "0x40A030", VA = "0x1040B230")]
    public AdvanceEventSelector()
    {
    }
  }
}
