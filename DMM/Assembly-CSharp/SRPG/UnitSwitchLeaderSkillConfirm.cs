// Decompiled with JetBrains decompiler
// Type: SRPG.UnitSwitchLeaderSkillConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D05")]
  [FlowNode.Pin(20, "リーダースキルを切り替えなかった", FlowNode.PinTypes.Output, 20)]
  [AddComponentMenu("UI/UnitSwitchLeaderSkillConfirm")]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(5, "Initialized", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(10, "リーダースキルを切り替えた", FlowNode.PinTypes.Output, 10)]
  public class UnitSwitchLeaderSkillConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DFF0")]
    public const int INIT = 1;
    [Token(Token = "0x400DFF1")]
    public const int OUTPUT_INITIALIZED = 5;
    [Token(Token = "0x400DFF2")]
    public const int OUTPUT_SWITCHED_LEADERSKILL = 10;
    [Token(Token = "0x400DFF3")]
    public const int OUTPUT_NOT_SWITCHED_LEADERSKILL = 20;
    [Token(Token = "0x400DFF4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject UnitLeaderSkillObject;
    [Token(Token = "0x400DFF5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject CCLeaderSkillObject;
    [Token(Token = "0x400DFF6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject Prefab_LeaderSkillDetail;
    [Token(Token = "0x400DFF7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button UnitLeaderSkillButton;
    [Token(Token = "0x400DFF8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button CCLeaderSkillButton;
    [Token(Token = "0x400DFF9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SRPG_Button ButtonOK;
    [Token(Token = "0x400DFFA")]
    [FieldOffset(Offset = "0x24")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400DFFB")]
    [FieldOffset(Offset = "0x28")]
    private SkillData mUnitLeaderSkill;
    [Token(Token = "0x400DFFC")]
    [FieldOffset(Offset = "0x2C")]
    private SkillData mCCLeaderSkill;
    [Token(Token = "0x400DFFD")]
    [FieldOffset(Offset = "0x30")]
    private GameObject mSkillDetail;
    [Token(Token = "0x400DFFE")]
    [FieldOffset(Offset = "0x34")]
    private bool mEquipConceptCardLeaderSkill;

    [Token(Token = "0x600D19C")]
    [Address(RVA = "0x9C9BD0", Offset = "0x9C89D0", VA = "0x109C9BD0")]
    private bool Init() => new bool();

    [Token(Token = "0x600D19D")]
    [Address(RVA = "0x9C9B70", Offset = "0x9C8970", VA = "0x109C9B70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D19E")]
    [Address(RVA = "0x9C9F20", Offset = "0x9C8D20", VA = "0x109C9F20")]
    private void OnButtonClickOK(SRPG_Button go)
    {
    }

    [Token(Token = "0x600D19F")]
    [Address(RVA = "0x9C9F90", Offset = "0x9C8D90", VA = "0x109C9F90")]
    private void OnSwitchLeaderSkill(SRPG_Button go)
    {
    }

    [Token(Token = "0x600D1A0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitSwitchLeaderSkillConfirm()
    {
    }
  }
}
