// Decompiled with JetBrains decompiler
// Type: SRPG.UnitJobDropdown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C42")]
  [FlowNode.Pin(1, "Apply Job", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(11, "Job Change&Close", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "Job Change&InvalidSkill", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(10, "Job Change(TmpUnit)", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "Apply InvalidSkill", FlowNode.PinTypes.Input, 1)]
  public class UnitJobDropdown : Pulldown, IFlowInterface
  {
    [Token(Token = "0x400DB24")]
    public const int INPUT_APPLY_JOB = 1;
    [Token(Token = "0x400DB25")]
    public const int INPUT_APPLY_INVALID_SKILL = 2;
    [Token(Token = "0x400DB26")]
    public const int OUTPUT_JOB_CHANGE_TMP_UNIT = 10;
    [Token(Token = "0x400DB27")]
    public const int OUTPUT_JOB_CHANGE_AND_CLOSE = 11;
    [Token(Token = "0x400DB28")]
    public const int OUTPUT_JOB_CHANGE_AND_INVALID_SKILL = 12;
    [Token(Token = "0x400DB29")]
    [FieldOffset(Offset = "0x0")]
    public static UnitJobDropdown.JobChangeEvent OnJobChange;
    [Token(Token = "0x400DB2A")]
    [FieldOffset(Offset = "0xF4")]
    public RawImage JobIcon;
    [Token(Token = "0x400DB2B")]
    [FieldOffset(Offset = "0xF8")]
    public RawImage ItemJobIcon;
    [Token(Token = "0x400DB2C")]
    [FieldOffset(Offset = "0xFC")]
    public bool RefreshOnStart;
    [Token(Token = "0x400DB2D")]
    [FieldOffset(Offset = "0x100")]
    public GameObject GameParamterRoot;
    [Token(Token = "0x400DB2E")]
    [FieldOffset(Offset = "0x104")]
    public UnitJobDropdown.ParentObjectEvent UpdateValue;
    [Token(Token = "0x400DB2F")]
    [FieldOffset(Offset = "0x108")]
    private bool mRequestSent;
    [Token(Token = "0x400DB30")]
    [FieldOffset(Offset = "0x10C")]
    private UnitData mTargetUnit;
    [Token(Token = "0x400DB31")]
    [FieldOffset(Offset = "0x110")]
    private string mOriginalJobID;
    [Token(Token = "0x400DB32")]
    [FieldOffset(Offset = "0x114")]
    private bool mIsCloseWhenJobChangeRequest;
    [Token(Token = "0x400DB33")]
    [FieldOffset(Offset = "0x115")]
    private bool mIsInvalidSkillWhenJobChangeRequest;

    [Token(Token = "0x600CD02")]
    [Address(RVA = "0x97C6F0", Offset = "0x97B4F0", VA = "0x1097C6F0", Slot = "47")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CD03")]
    [Address(RVA = "0x97D670", Offset = "0x97C470", VA = "0x1097D670", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600CD04")]
    [Address(RVA = "0x97D100", Offset = "0x97BF00", VA = "0x1097D100")]
    private void RequestJobChange(
      bool immediate,
      bool is_close_when_jobchange_request = true,
      bool is_invalid_skill_open = false)
    {
    }

    [Token(Token = "0x600CD05")]
    [Address(RVA = "0x97C790", Offset = "0x97B590", VA = "0x1097C790")]
    private void JobChangeResult(WWWResult www)
    {
    }

    [Token(Token = "0x600CD06")]
    [Address(RVA = "0x97D9F0", Offset = "0x97C7F0", VA = "0x1097D9F0")]
    private void Success_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x600CD07")]
    [Address(RVA = "0x97D760", Offset = "0x97C560", VA = "0x1097D760")]
    private void Success_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x600CD08")]
    [Address(RVA = "0x97DBD0", Offset = "0x97C9D0", VA = "0x1097DBD0")]
    private void UpdateOverWriteJob()
    {
    }

    [Token(Token = "0x600CD09")]
    [Address(RVA = "0x97CAE0", Offset = "0x97B8E0", VA = "0x1097CAE0")]
    private void PostJobChange(bool is_close, bool is_invalid_skill)
    {
    }

    [Token(Token = "0x600CD0A")]
    [Address(RVA = "0x97CA80", Offset = "0x97B880", VA = "0x1097CA80")]
    private void OnApplicationPause(bool pausing)
    {
    }

    [Token(Token = "0x600CD0B")]
    [Address(RVA = "0x97CA20", Offset = "0x97B820", VA = "0x1097CA20")]
    private void OnApplicationFocus(bool focus)
    {
    }

    [Token(Token = "0x600CD0C")]
    [Address(RVA = "0x97C8C0", Offset = "0x97B6C0", VA = "0x1097C8C0")]
    private void JobChanged(int value)
    {
    }

    [Token(Token = "0x600CD0D")]
    [Address(RVA = "0x97CE40", Offset = "0x97BC40", VA = "0x1097CE40")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600CD0E")]
    [Address(RVA = "0x97D610", Offset = "0x97C410", VA = "0x1097D610", Slot = "42")]
    protected override PulldownItem SetupPulldownItem(GameObject itemObject) => (PulldownItem) null;

    [Token(Token = "0x600CD0F")]
    [Address(RVA = "0x97DD20", Offset = "0x97CB20", VA = "0x1097DD20", Slot = "46")]
    protected override void UpdateSelection()
    {
    }

    [Token(Token = "0x600CD10")]
    [Address(RVA = "0x97DF90", Offset = "0x97CD90", VA = "0x1097DF90")]
    public UnitJobDropdown()
    {
    }

    [Token(Token = "0x600CD11")]
    [Address(RVA = "0x97DE50", Offset = "0x97CC50", VA = "0x1097DE50")]
    static UnitJobDropdown()
    {
    }

    [Token(Token = "0x2002C43")]
    public delegate void JobChangeEvent(long unitUniqueID);

    [Token(Token = "0x2002C44")]
    public class JobPulldownItem : PulldownItem
    {
      [Token(Token = "0x400DB34")]
      [FieldOffset(Offset = "0x24")]
      public string JobID;
      [Token(Token = "0x400DB35")]
      [FieldOffset(Offset = "0x28")]
      public RawImage JobIcon;

      [Token(Token = "0x600CD16")]
      [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
      public JobPulldownItem()
      {
      }
    }

    [Token(Token = "0x2002C45")]
    public delegate void ParentObjectEvent();

    [Token(Token = "0x2002C46")]
    [MessagePackObject(true)]
    public class MP_UnitJob_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400DB36")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitJob_OverWrite.Response body;

      [Token(Token = "0x600CD1B")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_UnitJob_OverWriteResponse()
      {
      }
    }
  }
}
