// Decompiled with JetBrains decompiler
// Type: SRPG.TipsInfoDetail
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
  [Token(Token = "0x2002B27")]
  [FlowNode.Pin(10, "既読送信の前準備", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "次のページボタン", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "前のページボタン", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/TipsInfoDetail")]
  [FlowNode.Pin(1000, "何もしない", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(100, "既読送信", FlowNode.PinTypes.Output, 100)]
  public class TipsInfoDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D291")]
    private const int PIN_INIT = 0;
    [Token(Token = "0x400D292")]
    private const int PIN_NEXT_BUTTON = 1;
    [Token(Token = "0x400D293")]
    private const int PIN_PREV_BUTTON = 2;
    [Token(Token = "0x400D294")]
    private const int PIN_REQUEST = 10;
    [Token(Token = "0x400D295")]
    private const int PIN_OUT_REQUEST = 100;
    [Token(Token = "0x400D296")]
    private const int PIN_OUT_DONOTHING = 1000;
    [Token(Token = "0x400D297")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ContentsHolder;
    [Token(Token = "0x400D298")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ContentTemplate;
    [Token(Token = "0x400D299")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScrollAutoFit ScrollController;
    [Token(Token = "0x400D29A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button PrevButton;
    [Token(Token = "0x400D29B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button NextButton;
    [Token(Token = "0x400D29C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ParentPageIcon;
    [Token(Token = "0x400D29D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject TemplatePageIcon;
    [Token(Token = "0x400D29E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button CloseButton;
    [Token(Token = "0x400D29F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private BackHandler CloseButtonBackHandler;
    [Token(Token = "0x400D2A0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400D2A1")]
    [FieldOffset(Offset = "0x34")]
    private List<Toggle> mToggleIconList;
    [Token(Token = "0x400D2A2")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> mContents;
    [Token(Token = "0x400D2A3")]
    [FieldOffset(Offset = "0x3C")]
    private TipsParam mTipsParam;
    [Token(Token = "0x400D2A4")]
    [FieldOffset(Offset = "0x40")]
    private int mCurrentPageIndex;
    [Token(Token = "0x400D2A5")]
    [FieldOffset(Offset = "0x44")]
    private bool mInitialized;

    [Token(Token = "0x600C578")]
    [Address(RVA = "0x8DFCE0", Offset = "0x8DEAE0", VA = "0x108DFCE0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C579")]
    [Address(RVA = "0x8E00D0", Offset = "0x8DEED0", VA = "0x108E00D0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600C57A")]
    [Address(RVA = "0x8DFB00", Offset = "0x8DE900", VA = "0x108DFB00", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C57B")]
    [Address(RVA = "0x8E0890", Offset = "0x8DF690", VA = "0x108E0890")]
    public void OnPageChanged(float value)
    {
    }

    [Token(Token = "0x600C57C")]
    [Address(RVA = "0x8DFED0", Offset = "0x8DECD0", VA = "0x108DFED0")]
    private void ChangeButtonInteractable()
    {
    }

    [Token(Token = "0x600C57D")]
    [Address(RVA = "0x8DFFE0", Offset = "0x8DEDE0", VA = "0x108DFFE0")]
    private void ChangeDot()
    {
    }

    [Token(Token = "0x600C57E")]
    [Address(RVA = "0x8E0090", Offset = "0x8DEE90", VA = "0x108E0090")]
    private void EnabledCloseButton(bool isEnable)
    {
    }

    [Token(Token = "0x600C57F")]
    [Address(RVA = "0x8E09E0", Offset = "0x8DF7E0", VA = "0x108E09E0")]
    private void OnReset()
    {
    }

    [Token(Token = "0x600C580")]
    [Address(RVA = "0x8E0CF0", Offset = "0x8DFAF0", VA = "0x108E0CF0")]
    public TipsInfoDetail()
    {
    }
  }
}
