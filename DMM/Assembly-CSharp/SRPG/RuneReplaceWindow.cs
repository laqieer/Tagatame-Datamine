// Decompiled with JetBrains decompiler
// Type: SRPG.RuneReplaceWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029C9")]
  [FlowNode.Pin(41, "フィルター", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(121, "交換通信", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(122, "装備アニメーションを実行", FlowNode.PinTypes.Output, 122)]
  [FlowNode.Pin(111, "更新", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(62, "詳細ウインドウを閉じる", FlowNode.PinTypes.Input, 62)]
  [FlowNode.Pin(61, "詳細ウインドウを開く", FlowNode.PinTypes.Input, 61)]
  [FlowNode.Pin(51, "刻印交換をキャンセル", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(161, "刻印詳細", FlowNode.PinTypes.Output, 161)]
  [FlowNode.Pin(141, "フィルター", FlowNode.PinTypes.Output, 141)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(31, "装備者：ＯＮ", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(21, "アニメーションの実行", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(12, "通信後更新", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(192, "画面クリックを不許可", FlowNode.PinTypes.Output, 192)]
  [FlowNode.Pin(32, "装備者：ＯＦＦ", FlowNode.PinTypes.Input, 32)]
  [FlowNode.Pin(191, "画面クリックを許可", FlowNode.PinTypes.Output, 191)]
  public class RuneReplaceWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CABC")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400CABD")]
    private const int PIN_IN_REFRESH = 11;
    [Token(Token = "0x400CABE")]
    private const int PIN_IN_API_REFRESH = 12;
    [Token(Token = "0x400CABF")]
    private const int PIN_IN_ANIMETION = 21;
    [Token(Token = "0x400CAC0")]
    private const int PIN_IN_EQUIP_TOGGLE_ON = 31;
    [Token(Token = "0x400CAC1")]
    private const int PIN_IN_EQUIP_TOGGLE_OFF = 32;
    [Token(Token = "0x400CAC2")]
    private const int PIN_IN_FILTER = 41;
    [Token(Token = "0x400CAC3")]
    private const int PIN_IN_CANCEL = 51;
    [Token(Token = "0x400CAC4")]
    private const int PIN_IN_DETAIL_OPEN = 61;
    [Token(Token = "0x400CAC5")]
    private const int PIN_IN_DETAIL_CLOSE = 62;
    [Token(Token = "0x400CAC6")]
    private const int PIN_OUTPUT_RUNE_UPDATE = 111;
    [Token(Token = "0x400CAC7")]
    private const int PIN_OUTPUT_RUNE_EXCHANGE = 121;
    [Token(Token = "0x400CAC8")]
    private const int PIN_OUTPUT_ANIMETION = 122;
    [Token(Token = "0x400CAC9")]
    private const int PIN_OUTPUT_RUNE_FILTER = 141;
    [Token(Token = "0x400CACA")]
    private const int PIN_OUTPUT_RUNE_DETAIL = 161;
    [Token(Token = "0x400CACB")]
    private const int PIN_OUTPUT_BLOCK_RAYCAST_ON = 191;
    [Token(Token = "0x400CACC")]
    private const int PIN_OUTPUT_BLOCK_RAYCAST_OFF = 192;
    [Token(Token = "0x400CACD")]
    [FieldOffset(Offset = "0xC")]
    private readonly string RUNE_REPLACE_CHECK_WINDOW_TEXT;
    [Token(Token = "0x400CACE")]
    [FieldOffset(Offset = "0x10")]
    private readonly string RUNE_REPLACE_CHECK_WINDOW_OK;
    [Token(Token = "0x400CACF")]
    [FieldOffset(Offset = "0x14")]
    private readonly string RUNE_REPLACE_CHECK_WINDOW_CANCEL;
    [Token(Token = "0x400CAD0")]
    private const string SVB_RUNE_ID_KEY = "Rune";
    [Token(Token = "0x400CAD1")]
    public const string PREFAB_PATH_RUNE_EQUIP_WINDOW = "UI/Rune/RuneEquipWindow";
    [Token(Token = "0x400CAD2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400CAD3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x400CAD4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentExhibit mUnitContentList;
    [Token(Token = "0x400CAD5")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SerializeValueBehaviour mSerializeValueBehaviour;
    [Token(Token = "0x400CAD6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Toggle mIsEquipFilterToggle;
    [Token(Token = "0x400CAD7")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private RuneReplaceContentNode mTargetContentNode;
    [Token(Token = "0x400CAD8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CustomSound mSoundEffect;
    [Token(Token = "0x400CAD9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mRuneDetailWindowParent;
    [Token(Token = "0x400CADA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mRuneDetailBg;
    [Token(Token = "0x400CADB")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private List<RuneReplaceWindowElementTab> mTabList;
    [Token(Token = "0x400CADC")]
    [FieldOffset(Offset = "0x40")]
    private RuneEquipWindow mRuneEquipWindow;
    [Token(Token = "0x400CADD")]
    [FieldOffset(Offset = "0x44")]
    private RuneReplaceContentNode mSelectContentNode;
    [Token(Token = "0x400CADE")]
    [FieldOffset(Offset = "0x48")]
    private List<RuneReplaceContentNodeModel> mContentModelList;
    [Token(Token = "0x400CADF")]
    [FieldOffset(Offset = "0x4C")]
    private RuneReplaceWindowModel mModel;
    [Token(Token = "0x400CAE0")]
    [FieldOffset(Offset = "0x0")]
    private static RuneReplaceWindow mInstance;

    [Token(Token = "0x170019AC")]
    public static RuneReplaceWindow Instance
    {
      [Token(Token = "0x600BE38"), Address(RVA = "0x85CC30", Offset = "0x85BA30", VA = "0x1085CC30")] get
      {
        return (RuneReplaceWindow) null;
      }
    }

    [Token(Token = "0x600BE39")]
    [Address(RVA = "0x85B810", Offset = "0x85A610", VA = "0x1085B810")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BE3A")]
    [Address(RVA = "0x85C350", Offset = "0x85B150", VA = "0x1085C350")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BE3B")]
    [Address(RVA = "0x85C060", Offset = "0x85AE60", VA = "0x1085C060")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BE3C")]
    [Address(RVA = "0x85BD50", Offset = "0x85AB50", VA = "0x1085BD50")]
    public void InitializeTab()
    {
    }

    [Token(Token = "0x600BE3D")]
    [Address(RVA = "0x85B550", Offset = "0x85A350", VA = "0x1085B550", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BE3E")]
    [Address(RVA = "0x85CA40", Offset = "0x85B840", VA = "0x1085CA40")]
    private void Setup()
    {
    }

    [Token(Token = "0x600BE3F")]
    [Address(RVA = "0x85B8E0", Offset = "0x85A6E0", VA = "0x1085B8E0")]
    private void ContentRuneSetup(ContentNode node, RuneReplaceContentNodeModel model)
    {
    }

    [Token(Token = "0x600BE40")]
    [Address(RVA = "0x85C130", Offset = "0x85AF30", VA = "0x1085C130")]
    public void OnClickRuneReplace(string iname)
    {
    }

    [Token(Token = "0x600BE41")]
    [Address(RVA = "0x85C5E0", Offset = "0x85B3E0", VA = "0x1085C5E0")]
    private void RuneReplaceExecution()
    {
    }

    [Token(Token = "0x600BE42")]
    [Address(RVA = "0x85C5C0", Offset = "0x85B3C0", VA = "0x1085C5C0")]
    private void RuneReplaceCancel()
    {
    }

    [Token(Token = "0x600BE43")]
    [Address(RVA = "0x85C760", Offset = "0x85B560", VA = "0x1085C760")]
    public void SetRuneID(long runeId)
    {
    }

    [Token(Token = "0x600BE44")]
    [Address(RVA = "0x85BC00", Offset = "0x85AA00", VA = "0x1085BC00")]
    public void EquipAnimation()
    {
    }

    [Token(Token = "0x600BE45")]
    [Address(RVA = "0x85C870", Offset = "0x85B670", VA = "0x1085C870")]
    private void SetUnitDisp()
    {
    }

    [Token(Token = "0x600BE46")]
    [Address(RVA = "0x85C3C0", Offset = "0x85B1C0", VA = "0x1085C3C0")]
    public void OpenRuneStatusWindow(UnitData unitData, BindRuneData bindRuneData)
    {
    }

    [Token(Token = "0x600BE47")]
    [Address(RVA = "0x85B850", Offset = "0x85A650", VA = "0x1085B850")]
    public void CloseRuneStatusWindow()
    {
    }

    [Token(Token = "0x600BE48")]
    [Address(RVA = "0x85BAE0", Offset = "0x85A8E0", VA = "0x1085BAE0")]
    public IEnumerator CreateRuneDetialWindow(UnitData unitData, BindRuneData bindRuneData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BE49")]
    [Address(RVA = "0x85BB60", Offset = "0x85A960", VA = "0x1085BB60")]
    public void DeleteRuneDetialWindow()
    {
    }

    [Token(Token = "0x600BE4A")]
    [Address(RVA = "0x85C6F0", Offset = "0x85B4F0", VA = "0x1085C6F0")]
    public void SaveNoEquipFilter()
    {
    }

    [Token(Token = "0x600BE4B")]
    [Address(RVA = "0x85C710", Offset = "0x85B510", VA = "0x1085C710")]
    public void SetCurrentTab(RuneReplaceWindowElementTabModel model)
    {
    }

    [Token(Token = "0x600BE4C")]
    [Address(RVA = "0x85C830", Offset = "0x85B630", VA = "0x1085C830")]
    public void SetToggleData(bool isOn)
    {
    }

    [Token(Token = "0x600BE4D")]
    [Address(RVA = "0x85C530", Offset = "0x85B330", VA = "0x1085C530")]
    private void ResetScrollPosition()
    {
    }

    [Token(Token = "0x600BE4E")]
    [Address(RVA = "0x85CB60", Offset = "0x85B960", VA = "0x1085CB60")]
    public RuneReplaceWindow()
    {
    }
  }
}
