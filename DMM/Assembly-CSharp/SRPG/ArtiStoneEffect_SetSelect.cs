// Decompiled with JetBrains decompiler
// Type: SRPG.ArtiStoneEffect_SetSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FF3")]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(101, "DECIDE", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(12, "ConfirmNo", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(2, "UpdateYes", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(4, "UpdateRetry", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "UpdateNo", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "ConfirmYes", FlowNode.PinTypes.Input, 11)]
  public class ArtiStoneEffect_SetSelect : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40087F0")]
    public const string SVB_KEY_ARTIFACT_IID = "SVB_KEY_ARTIFACT_IID";
    [Token(Token = "0x40087F1")]
    public const string SVB_KEY_IS_UPDATE_VALUE = "SVB_KEY_IS_UPDATE_VALUE";
    [Token(Token = "0x40087F2")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x40087F3")]
    private const int PIN_IN_UPDATE_YES = 2;
    [Token(Token = "0x40087F4")]
    private const int PIN_IN_UPDATE_NO = 3;
    [Token(Token = "0x40087F5")]
    private const int PIN_IN_UPDATE_RETRY = 4;
    [Token(Token = "0x40087F6")]
    private const int PIN_IN_CONFIRM_YES = 11;
    [Token(Token = "0x40087F7")]
    private const int PIN_IN_CONFIRM_NO = 12;
    [Token(Token = "0x40087F8")]
    private const int PIN_OUT_DECIDE = 101;
    [Token(Token = "0x40087F9")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x40087FA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x40087FB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mNowStoneEffectExhibitList;
    [Token(Token = "0x40087FC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ExhibitList mNewStoneEffectExhibitList;
    [Token(Token = "0x40087FD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ExhibitList mConfirmEffectExhibitList;
    [Token(Token = "0x40087FE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mConfirmTextUpdate;
    [Token(Token = "0x40087FF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mConfirmTextDelete;
    [Token(Token = "0x4008800")]
    [FieldOffset(Offset = "0x24")]
    private ArtifactData mCurrentArtifact;
    [Token(Token = "0x4008801")]
    [FieldOffset(Offset = "0x28")]
    private string mNewLotteryStoneEffectIname;
    [Token(Token = "0x4008802")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsUpdate;

    [Token(Token = "0x60083E8")]
    [Address(RVA = "0x4478F0", Offset = "0x4466F0", VA = "0x104478F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60083E9")]
    [Address(RVA = "0x447BB0", Offset = "0x4469B0", VA = "0x10447BB0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x60083EA")]
    [Address(RVA = "0x447EB0", Offset = "0x446CB0", VA = "0x10447EB0")]
    private void SelectUpdate(bool is_update, bool is_retry)
    {
    }

    [Token(Token = "0x60083EB")]
    [Address(RVA = "0x447AB0", Offset = "0x4468B0", VA = "0x10447AB0")]
    private void ConfirmDecision()
    {
    }

    [Token(Token = "0x60083EC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiStoneEffect_SetSelect()
    {
    }
  }
}
