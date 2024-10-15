// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestChapterSelectorView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200280B")]
  [FlowNode.Pin(103, "シーン遷移アニメーション開始", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(104, "シーン遷移アニメーション終了", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(106, "センタリング終了", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(102, "未解放をセレクト", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(105, "センタリング開始", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(101, "期間外をセレクト", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(3, "右矢印タップ", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "左矢印タップ", FlowNode.PinTypes.Input, 2)]
  public class PointQuestChapterSelectorView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BEB0")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400BEB1")]
    private const int PIN_INPUT_LEFT_ARROW = 2;
    [Token(Token = "0x400BEB2")]
    private const int PIN_INPUT_RIGHT_ARROW = 3;
    [Token(Token = "0x400BEB3")]
    private const int PIN_OUTPUT_OUT_OF_PERIOD = 101;
    [Token(Token = "0x400BEB4")]
    private const int PIN_OUTPUT_NO_LIBERATION = 102;
    [Token(Token = "0x400BEB5")]
    private const int PIN_OUTPUT_START_ANIM = 103;
    [Token(Token = "0x400BEB6")]
    private const int PIN_OUTPUT_END_ANIM = 104;
    [Token(Token = "0x400BEB7")]
    private const int PIN_OUTPUT_START_CENTERING = 105;
    [Token(Token = "0x400BEB8")]
    private const int PIN_OUTPUT_END_CENTERING = 106;
    [Token(Token = "0x400BEB9")]
    public const string KEY_CENTER_CHAPTER_INAME = "KEY_CENTER_CHAPTER_INAME";
    [Token(Token = "0x400BEBA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform ListParent;
    [Token(Token = "0x400BEBB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PointQuestChapterSelectorItem ItemTemplate;
    [Token(Token = "0x400BEBC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private PointQuestChapterScrollRect ScrollRect;
    [Token(Token = "0x400BEBD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400BEBE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject MarginObj;
    [Token(Token = "0x400BEBF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform LeftCirculationParent;
    [Token(Token = "0x400BEC0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform RightCirculationParent;
    [Token(Token = "0x400BEC1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollablePulldownCustom ChapterPullDown;
    [Token(Token = "0x400BEC2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int FunctionStartArrowNum;
    [Token(Token = "0x400BEC3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int ScrollArrowNum;
    [Token(Token = "0x400BEC4")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private bool IsScrollLowerArrowNum;
    [Token(Token = "0x400BEC5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int PullDownDispNum;
    [Token(Token = "0x400BEC6")]
    [FieldOffset(Offset = "0x3C")]
    private PointQuestChapterSelectorModel mModel;
    [Token(Token = "0x400BEC7")]
    [FieldOffset(Offset = "0x40")]
    private List<PointQuestChapterSelectorItem> mItemList;
    [Token(Token = "0x400BEC8")]
    [FieldOffset(Offset = "0x44")]
    private Dictionary<string, List<QuestParam>> mChapterQuestList;
    [Token(Token = "0x400BEC9")]
    [FieldOffset(Offset = "0x48")]
    private ChapterParam mCenterChapter;
    [Token(Token = "0x400BECA")]
    [FieldOffset(Offset = "0x4C")]
    private int mCenterIndex;
    [Token(Token = "0x400BECB")]
    [FieldOffset(Offset = "0x50")]
    private bool mFunctionArrowButton;

    [Token(Token = "0x600B4E3")]
    [Address(RVA = "0x7B39D0", Offset = "0x7B27D0", VA = "0x107B39D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B4E4")]
    [Address(RVA = "0x7B3BF0", Offset = "0x7B29F0", VA = "0x107B3BF0")]
    private void Init()
    {
    }

    [Token(Token = "0x600B4E5")]
    [Address(RVA = "0x7B4800", Offset = "0x7B3600", VA = "0x107B4800")]
    private GameObject InstantiateMarginObj() => (GameObject) null;

    [Token(Token = "0x600B4E6")]
    [Address(RVA = "0x7B4E30", Offset = "0x7B3C30", VA = "0x107B4E30")]
    private void SetModelData()
    {
    }

    [Token(Token = "0x600B4E7")]
    [Address(RVA = "0x7B3B30", Offset = "0x7B2930", VA = "0x107B3B30")]
    private void Draw()
    {
    }

    [Token(Token = "0x600B4E8")]
    [Address(RVA = "0x7B5000", Offset = "0x7B3E00", VA = "0x107B5000")]
    public void SetQuestChapter(int _index)
    {
    }

    [Token(Token = "0x600B4E9")]
    [Address(RVA = "0x7B48E0", Offset = "0x7B36E0", VA = "0x107B48E0")]
    public void OnClickChapterIcon(PointQuestChapterSelectorItem _item)
    {
    }

    [Token(Token = "0x600B4EA")]
    [Address(RVA = "0x7B3BD0", Offset = "0x7B29D0", VA = "0x107B3BD0")]
    public void EndItemAnimation()
    {
    }

    [Token(Token = "0x600B4EB")]
    [Address(RVA = "0x7B5270", Offset = "0x7B4070", VA = "0x107B5270")]
    public void StartCentering()
    {
    }

    [Token(Token = "0x600B4EC")]
    [Address(RVA = "0x7B3BB0", Offset = "0x7B29B0", VA = "0x107B3BB0")]
    public void EndCentering()
    {
    }

    [Token(Token = "0x600B4ED")]
    [Address(RVA = "0x7B50A0", Offset = "0x7B3EA0", VA = "0x107B50A0")]
    private void SetupPullDownButton()
    {
    }

    [Token(Token = "0x600B4EE")]
    [Address(RVA = "0x7B3AC0", Offset = "0x7B28C0", VA = "0x107B3AC0")]
    private void CallBackOnPullDownMenu(int value)
    {
    }

    [Token(Token = "0x600B4EF")]
    [Address(RVA = "0x7B4F70", Offset = "0x7B3D70", VA = "0x107B4F70")]
    public void SetPullDownSelection(int value)
    {
    }

    [Token(Token = "0x600B4F0")]
    [Address(RVA = "0x7B5290", Offset = "0x7B4090", VA = "0x107B5290")]
    public PointQuestChapterSelectorView()
    {
    }
  }
}
