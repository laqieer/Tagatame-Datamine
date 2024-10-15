// Decompiled with JetBrains decompiler
// Type: SRPG.UnitJobListPullDown
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
  [Token(Token = "0x2002C50")]
  [FlowNode.Pin(1, "Apply Job", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(22, "Job Change&InvalidSkill", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(20, "Job Change(TmpUnit)", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(41, "ジョブ切り替えAPI", FlowNode.PinTypes.Output, 41)]
  [FlowNode.Pin(2, "Apply InvalidSkill", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(11, "jobChange", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(32, "Refresh", FlowNode.PinTypes.Output, 32)]
  [FlowNode.Pin(21, "Job Change&Close", FlowNode.PinTypes.Output, 21)]
  public class UnitJobListPullDown : Pulldown, IFlowInterface
  {
    [Token(Token = "0x400DB5B")]
    public const int INPUT_APPLY_JOB = 1;
    [Token(Token = "0x400DB5C")]
    public const int INPUT_APPLY_INVALID_SKILL = 2;
    [Token(Token = "0x400DB5D")]
    public const int INPUT_JOB_CHANGE = 11;
    [Token(Token = "0x400DB5E")]
    public const int OUTPUT_JOB_CHANGE_TMP_UNIT = 20;
    [Token(Token = "0x400DB5F")]
    public const int OUTPUT_JOB_CHANGE_AND_CLOSE = 21;
    [Token(Token = "0x400DB60")]
    public const int OUTPUT_JOB_CHANGE_AND_INVALID_SKILL = 22;
    [Token(Token = "0x400DB61")]
    public const int OUTPUT_REFRESH = 32;
    [Token(Token = "0x400DB62")]
    public const int OUTPUT_JOB_CHANGE_REQUEST_API = 41;
    [Token(Token = "0x400DB63")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400DB64")]
    [FieldOffset(Offset = "0xF8")]
    private List<UnitJobList> PullDonwItems;
    [Token(Token = "0x400DB65")]
    [FieldOffset(Offset = "0xFC")]
    private UnitJobListPullDownModel mModel;
    [Token(Token = "0x400DB66")]
    [FieldOffset(Offset = "0x0")]
    public static UnitJobListPullDown.JobChangeEvent OnJobChange;
    [Token(Token = "0x400DB67")]
    [FieldOffset(Offset = "0x100")]
    public bool RefreshOnStart;
    [Token(Token = "0x400DB68")]
    [FieldOffset(Offset = "0x104")]
    public GameObject GameParamterRoot;
    [Token(Token = "0x400DB69")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private UnitToolTipWindowEx mUnitToolTip;
    [Token(Token = "0x400DB6A")]
    [FieldOffset(Offset = "0x10C")]
    public UnitJobListPullDown.ParentObjectEvent UpdateValue;
    [Token(Token = "0x400DB6B")]
    [FieldOffset(Offset = "0x110")]
    private bool mRequestSent;
    [Token(Token = "0x400DB6C")]
    [FieldOffset(Offset = "0x111")]
    private bool mIsCloseWhenJobChangeRequest;
    [Token(Token = "0x400DB6D")]
    [FieldOffset(Offset = "0x112")]
    private bool mIsInvalidSkillWhenJobChangeRequest;

    [Token(Token = "0x600CD45")]
    [Address(RVA = "0x97F410", Offset = "0x97E210", VA = "0x1097F410", Slot = "47")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CD46")]
    [Address(RVA = "0x9802C0", Offset = "0x97F0C0", VA = "0x109802C0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600CD47")]
    [Address(RVA = "0x97FE40", Offset = "0x97EC40", VA = "0x1097FE40")]
    private void RequestJobChange(
      bool immediate,
      bool is_close_when_jobchange_request = true,
      bool is_invalid_skill_open = false)
    {
    }

    [Token(Token = "0x600CD48")]
    [Address(RVA = "0x8F09D0", Offset = "0x8EF7D0", VA = "0x108F09D0")]
    private void UpdateOverWriteJob()
    {
    }

    [Token(Token = "0x600CD49")]
    [Address(RVA = "0x97F8C0", Offset = "0x97E6C0", VA = "0x1097F8C0")]
    private void PostJobChange(bool is_close, bool is_invalid_skill)
    {
    }

    [Token(Token = "0x600CD4A")]
    [Address(RVA = "0x97F880", Offset = "0x97E680", VA = "0x1097F880")]
    private void OnApplicationPause(bool pausing)
    {
    }

    [Token(Token = "0x600CD4B")]
    [Address(RVA = "0x97F840", Offset = "0x97E640", VA = "0x1097F840")]
    private void OnApplicationFocus(bool focus)
    {
    }

    [Token(Token = "0x600CD4C")]
    [Address(RVA = "0x97F710", Offset = "0x97E510", VA = "0x1097F710")]
    private void JobChanged(int value)
    {
    }

    [Token(Token = "0x600CD4D")]
    [Address(RVA = "0x97F6D0", Offset = "0x97E4D0", VA = "0x1097F6D0")]
    public void Initialize(UnitData unitData, bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600CD4E")]
    [Address(RVA = "0x980230", Offset = "0x97F030", VA = "0x10980230")]
    public void SetupModel(UnitData unitData, bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600CD4F")]
    [Address(RVA = "0x97F4C0", Offset = "0x97E2C0", VA = "0x1097F4C0")]
    public void CreatePullDown()
    {
    }

    [Token(Token = "0x600CD50")]
    [Address(RVA = "0x97FBF0", Offset = "0x97E9F0", VA = "0x1097FBF0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600CD51")]
    [Address(RVA = "0x97FD90", Offset = "0x97EB90", VA = "0x1097FD90")]
    public void Refresh(UnitData unitData)
    {
    }

    [Token(Token = "0x600CD52")]
    [Address(RVA = "0x9804E0", Offset = "0x97F2E0", VA = "0x109804E0")]
    public UnitJobListPullDown()
    {
    }

    [Token(Token = "0x600CD53")]
    [Address(RVA = "0x9803A0", Offset = "0x97F1A0", VA = "0x109803A0")]
    static UnitJobListPullDown()
    {
    }

    [Token(Token = "0x2002C51")]
    public delegate void JobChangeEvent(long unitUniqueID);

    [Token(Token = "0x2002C52")]
    public delegate void ParentObjectEvent();
  }
}
