// Decompiled with JetBrains decompiler
// Type: SRPG.InspirationSkillResetWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C7A")]
  [FlowNode.Pin(101, "ボタン有効化", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(191, "エラー", FlowNode.PinTypes.Output, 191)]
  [FlowNode.Pin(1, "表示更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "リセット実行完了", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(102, "終了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(3, "キャンセル実行", FlowNode.PinTypes.Input, 3)]
  public class InspirationSkillResetWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40021D6")]
    private const int PIN_IN_SETUP = 1;
    [Token(Token = "0x40021D7")]
    private const int PIN_IN_RESET_FIN = 2;
    [Token(Token = "0x40021D8")]
    private const int PIN_IN_RESET_CANCEL = 3;
    [Token(Token = "0x40021D9")]
    private const int PIN_OUT_BUTTON_ENABLE = 101;
    [Token(Token = "0x40021DA")]
    private const int PIN_OUT_RESET_FIN = 102;
    [Token(Token = "0x40021DB")]
    private const int PIN_OUT_RESET_ERROR = 191;
    [Token(Token = "0x40021DC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x40021DD")]
    [FieldOffset(Offset = "0x10")]
    private InspirationSkillResetModel mInspirationSkillResetModel;
    [Token(Token = "0x40021DE")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsInitialized;
    [Token(Token = "0x40021DF")]
    [FieldOffset(Offset = "0x18")]
    public InspirationSkillResetWindow.CallbackEvent OnResetExecuteCallback;
    [Token(Token = "0x40021E0")]
    [FieldOffset(Offset = "0x1C")]
    public InspirationSkillResetWindow.CallbackEvent OnResetCancelCallback;

    [Token(Token = "0x600312E")]
    [Address(RVA = "0x1022EF0", Offset = "0x1021CF0", VA = "0x11022EF0")]
    public void Initialize(ArtifactData artifact, InspirationSkillData inspi_skill_data)
    {
    }

    [Token(Token = "0x600312F")]
    [Address(RVA = "0x1022E90", Offset = "0x1021C90", VA = "0x11022E90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6003130")]
    [Address(RVA = "0x1023000", Offset = "0x1021E00", VA = "0x11023000")]
    private void Setup()
    {
    }

    [Token(Token = "0x6003131")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public InspirationSkillResetWindow()
    {
    }

    [Token(Token = "0x2000C7B")]
    public delegate void CallbackEvent();
  }
}
