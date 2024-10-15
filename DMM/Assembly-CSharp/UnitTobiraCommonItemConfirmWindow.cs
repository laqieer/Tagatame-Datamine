// Decompiled with JetBrains decompiler
// Type: UnitTobiraCommonItemConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000304")]
[FlowNode.Pin(100, "強化確認ボタン押下", FlowNode.PinTypes.Input, 100)]
[FlowNode.Pin(102, "閉じるボタン押下", FlowNode.PinTypes.Input, 102)]
[FlowNode.Pin(101, "閉じる", FlowNode.PinTypes.Output, 101)]
[AddComponentMenu("UI/UnitTobiraCommonItemConfirmWindow")]
public class UnitTobiraCommonItemConfirmWindow : MonoBehaviour, IFlowInterface
{
  [Token(Token = "0x4000C60")]
  private const int ON_CLICK_TOBIRA_ENHANCE_BUTTON = 100;
  [Token(Token = "0x4000C61")]
  private const int TOBIRA_ENHANCE_CLOSE = 101;
  [Token(Token = "0x4000C62")]
  private const int ON_CLICK_TOBIRA_CLOSE_BUTTON = 102;
  [Token(Token = "0x4000C63")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private GameObject mUnitPieceObj;
  [Token(Token = "0x4000C64")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private GameObject mSubPieceObj;
  [Token(Token = "0x4000C65")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private Text mUnitPieceShortageText;
  [Token(Token = "0x4000C66")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Text mSubPieceNeedText;
  [Token(Token = "0x4000C67")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private LText mSubPieceNameText;
  [Token(Token = "0x4000C68")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private LText mSubPieceAmmountText;
  [Token(Token = "0x4000C69")]
  [FieldOffset(Offset = "0x24")]
  private UnitData mCurrentUnit;
  [Token(Token = "0x4000C6A")]
  [FieldOffset(Offset = "0x28")]
  private TobiraData mCurrectTobira;
  [Token(Token = "0x4000C6B")]
  [FieldOffset(Offset = "0x2C")]
  private TobiraRecipeParam mCurrentRecipe;
  [Token(Token = "0x4000C6C")]
  [FieldOffset(Offset = "0x30")]
  public UnitTobiraCommonItemConfirmWindow.CallbackEvent OnEnhanceCallback;
  [Token(Token = "0x4000C6D")]
  [FieldOffset(Offset = "0x34")]
  public UnitTobiraCommonItemConfirmWindow.CallbackEvent OnCloseCallback;

  [Token(Token = "0x6000FA5")]
  [Address(RVA = "0x12AEEB0", Offset = "0x12ADCB0", VA = "0x112AEEB0", Slot = "4")]
  public void Activated(int pinID)
  {
  }

  [Token(Token = "0x6000FA6")]
  [Address(RVA = "0x12AF6E0", Offset = "0x12AE4E0", VA = "0x112AF6E0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000FA7")]
  [Address(RVA = "0x12AEFC0", Offset = "0x12ADDC0", VA = "0x112AEFC0")]
  public void Initialize(UnitData unit, TobiraData tobira, TobiraRecipeParam recipe)
  {
  }

  [Token(Token = "0x6000FA8")]
  [Address(RVA = "0x12AF010", Offset = "0x12ADE10", VA = "0x112AF010")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000FA9")]
  [Address(RVA = "0x12AF5A0", Offset = "0x12AE3A0", VA = "0x112AF5A0")]
  private void SetupUnitPieceData()
  {
  }

  [Token(Token = "0x6000FAA")]
  [Address(RVA = "0x12AF1A0", Offset = "0x12ADFA0", VA = "0x112AF1A0")]
  private void SetupSubPieceData()
  {
  }

  [Token(Token = "0x6000FAB")]
  [Address(RVA = "0x12AEF00", Offset = "0x12ADD00", VA = "0x112AEF00")]
  private int GetNeadPieceNum() => new int();

  [Token(Token = "0x6000FAC")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public UnitTobiraCommonItemConfirmWindow()
  {
  }

  [Token(Token = "0x2000305")]
  public delegate void CallbackEvent();
}
