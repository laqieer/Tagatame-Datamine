// Decompiled with JetBrains decompiler
// Type: SRPG.QuestChapterList
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
  [Token(Token = "0x200288E")]
  [AddComponentMenu("UI/QuestChapterList")]
  [FlowNode.Pin(200, "塔が選択された", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "アイテムが選択された", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(50, "再読み込み完了", FlowNode.PinTypes.Output, 50)]
  [FlowNode.Pin(40, "セクション選択に戻す", FlowNode.PinTypes.Output, 40)]
  [FlowNode.Pin(5, "章の選択情報を削除", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(4, "階層を上げる", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "セクション決定", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "ロケーションのハイライトを戻す", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1, "ワールドマップへ戻す", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(0, "再読み込み", FlowNode.PinTypes.Input, 40)]
  public class QuestChapterList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C1E0")]
    private const int PIN_IN_RELOAD = 0;
    [Token(Token = "0x400C1E1")]
    private const int PIN_IN_GOTO_WORLDMAP = 1;
    [Token(Token = "0x400C1E2")]
    private const int PIN_IN_RESET_LOC_HIGHLIGHT = 2;
    [Token(Token = "0x400C1E3")]
    private const int PIN_IN_DECIDE_SECTION = 3;
    [Token(Token = "0x400C1E4")]
    private const int PIN_IN_UPTO_LAYER = 4;
    [Token(Token = "0x400C1E5")]
    private const int PIN_IN_RESET_SELECT_CHAPTER = 5;
    [Token(Token = "0x400C1E6")]
    private const int PIN_OUT_GOTO_SECTION = 40;
    [Token(Token = "0x400C1E7")]
    private const int PIN_OUT_FINISH_RELOAD = 50;
    [Token(Token = "0x400C1E8")]
    private const int PIN_OUT_SELECT_ITEM = 100;
    [Token(Token = "0x400C1E9")]
    private const int PIN_OUT_SELECT_TOWER = 200;
    [Token(Token = "0x400C1EA")]
    [FieldOffset(Offset = "0xC")]
    public ListItemEvents ItemTemplate;
    [Token(Token = "0x400C1EB")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemContainer;
    [Token(Token = "0x400C1EC")]
    [FieldOffset(Offset = "0x14")]
    public string WorldMapControllerID;
    [Token(Token = "0x400C1ED")]
    [FieldOffset(Offset = "0x18")]
    public bool Descending;
    [Token(Token = "0x400C1EE")]
    [FieldOffset(Offset = "0x19")]
    public bool RefreshOnStart;
    [Token(Token = "0x400C1EF")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject BackButton;
    [Token(Token = "0x400C1F0")]
    [FieldOffset(Offset = "0x20")]
    public Vector2 DefaultScrollPos;
    [Token(Token = "0x400C1F1")]
    [FieldOffset(Offset = "0x28")]
    [Header("スクロール位置を再計算する")]
    [SerializeField]
    private SRPG_ScrollRect ChapterScrollRect;
    [Token(Token = "0x400C1F2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x400C1F3")]
    [FieldOffset(Offset = "0x30")]
    private float BITING_PREVENT_VELOCITY;
    [Token(Token = "0x400C1F4")]
    [FieldOffset(Offset = "0x34")]
    private List<ListItemEvents> mItems;

    [Token(Token = "0x1700190A")]
    private WorldMapController mWorldMap
    {
      [Token(Token = "0x600B73A"), Address(RVA = "0x7DCDC0", Offset = "0x7DBBC0", VA = "0x107DCDC0")] get
      {
        return (WorldMapController) null;
      }
    }

    [Token(Token = "0x600B73B")]
    [Address(RVA = "0x7DCCD0", Offset = "0x7DBAD0", VA = "0x107DCCD0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B73C")]
    [Address(RVA = "0x7DC990", Offset = "0x7DB790", VA = "0x107DC990")]
    public void ResetScroll()
    {
    }

    [Token(Token = "0x600B73D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnBackClick()
    {
    }

    [Token(Token = "0x600B73E")]
    [Address(RVA = "0x7DB1D0", Offset = "0x7D9FD0", VA = "0x107DB1D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B73F")]
    [Address(RVA = "0x7DB620", Offset = "0x7DA420", VA = "0x107DB620")]
    private bool IsSectionHidden(string iname) => new bool();

    [Token(Token = "0x600B740")]
    [Address(RVA = "0x7AB820", Offset = "0x7AA620", VA = "0x107AB820")]
    private bool ChapterContainsPlayableQuest(
      ChapterParam chapter,
      ChapterParam[] allChapters,
      QuestParam[] availableQuests,
      long currentTime)
    {
      return new bool();
    }

    [Token(Token = "0x600B741")]
    [Address(RVA = "0x5D2C40", Offset = "0x5D1A40", VA = "0x105D2C40")]
    private bool IsChapterChildOf(ChapterParam child, ChapterParam parent) => new bool();

    [Token(Token = "0x600B742")]
    [Address(RVA = "0x7DBE90", Offset = "0x7DAC90", VA = "0x107DBE90")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B743")]
    [Address(RVA = "0x7DCA50", Offset = "0x7DB850", VA = "0x107DCA50")]
    private void SetScrollPos(List<ChapterParam> chapters)
    {
    }

    [Token(Token = "0x600B744")]
    [Address(RVA = "0x7DB5A0", Offset = "0x7DA3A0", VA = "0x107DB5A0")]
    private IEnumerator InitScroll(Vector2 vector) => (IEnumerator) null;

    [Token(Token = "0x600B745")]
    [Address(RVA = "0x7DBA20", Offset = "0x7DA820", VA = "0x107DBA20")]
    private void OnNodeSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B746")]
    [Address(RVA = "0x7DB770", Offset = "0x7DA570", VA = "0x107DB770")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B747")]
    [Address(RVA = "0x7DBBC0", Offset = "0x7DA9C0", VA = "0x107DBBC0")]
    private void OnTowerSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B748")]
    [Address(RVA = "0x7DCD30", Offset = "0x7DBB30", VA = "0x107DCD30")]
    public QuestChapterList()
    {
    }
  }
}
