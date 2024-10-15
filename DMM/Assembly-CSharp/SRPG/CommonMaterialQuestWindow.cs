// Decompiled with JetBrains decompiler
// Type: SRPG.CommonMaterialQuestWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021B5")]
  [FlowNode.Pin(0, "表示を更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(51, "クエストをクリック", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(52, "クエスト詳細ボタンをクリック", FlowNode.PinTypes.Input, 52)]
  [FlowNode.Pin(101, "入手クエストが選択された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(103, "書庫解放確認", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(102, "閉じる：完了", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("UI/Common/CommonMaterialQuestWindow")]
  public class CommonMaterialQuestWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40093A3")]
    public const int ON_CLICK_QUEST_BUTTON = 51;
    [Token(Token = "0x40093A4")]
    public const int ON_CLICK_QUESTDETAIL_BUTTON = 52;
    [Token(Token = "0x40093A5")]
    public const int OUT_SELECT_QUEST = 101;
    [Token(Token = "0x40093A6")]
    public const int OUT_CLOSE_WINDOW = 102;
    [Token(Token = "0x40093A7")]
    public const int OUT_OPEN_ARCHIVE = 103;
    [Token(Token = "0x40093A8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject RootPanel;
    [Token(Token = "0x40093A9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ScrollRect ScrollParent;
    [Token(Token = "0x40093AA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform QuestListParent;
    [Token(Token = "0x40093AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject QuestListItemTemplate;
    [Token(Token = "0x40093AC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x40093AD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string QuestDetail;
    [Token(Token = "0x40093AE")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string QuestDetailMulti;
    [Token(Token = "0x40093AF")]
    [FieldOffset(Offset = "0x28")]
    protected QuestParam mCurrentQuest;
    [Token(Token = "0x40093B0")]
    [FieldOffset(Offset = "0x2C")]
    private LoadRequest mReqQuestDetail;
    [Token(Token = "0x40093B1")]
    [FieldOffset(Offset = "0x30")]
    private LoadRequest mReqQuestDefaultDetail;
    [Token(Token = "0x40093B2")]
    [FieldOffset(Offset = "0x34")]
    private LoadRequest mReqQuestMultiDetail;
    [Token(Token = "0x40093B3")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> mGainedQuests;

    [Token(Token = "0x6008DF1")]
    [Address(RVA = "0x518B00", Offset = "0x517900", VA = "0x10518B00")]
    private void Start()
    {
    }

    [Token(Token = "0x6008DF2")]
    [Address(RVA = "0x517AD0", Offset = "0x5168D0", VA = "0x10517AD0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008DF3")]
    [Address(RVA = "0x517F80", Offset = "0x516D80", VA = "0x10517F80")]
    private void CloseWindow()
    {
    }

    [Token(Token = "0x6008DF4")]
    [Address(RVA = "0x518630", Offset = "0x517430", VA = "0x10518630")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008DF5")]
    [Address(RVA = "0x517C10", Offset = "0x516A10", VA = "0x10517C10")]
    private void AddList(QuestParam qparam, bool isActive = false)
    {
    }

    [Token(Token = "0x6008DF6")]
    [Address(RVA = "0x517FA0", Offset = "0x516DA0", VA = "0x10517FA0")]
    private void OnQuestSelect(QuestParam quest)
    {
    }

    [Token(Token = "0x6008DF7")]
    [Address(RVA = "0x5184B0", Offset = "0x5172B0", VA = "0x105184B0")]
    private void OpenQuestDetail(QuestParam param)
    {
    }

    [Token(Token = "0x6008DF8")]
    [Address(RVA = "0x518BF0", Offset = "0x5179F0", VA = "0x10518BF0")]
    public CommonMaterialQuestWindow()
    {
    }
  }
}
