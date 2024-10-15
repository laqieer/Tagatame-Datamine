// Decompiled with JetBrains decompiler
// Type: SRPG.GuildConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002559")]
  [FlowNode.Pin(102, "ギルド加入申請を承認完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "ギルド加入申請を拒否完了", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(101, "ギルド加入申請リクエスト", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(7, "ギルド加入申請一括拒否", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(6, "ギルド脱退", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(5, "ギルドメンバー追放", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(106, "ギルド加入申請一括拒否完了", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(3, "ギルド加入申請を承認", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "ギルド加入申請", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/GuildConfirm")]
  [FlowNode.Pin(104, "ギルドメンバー追放完了", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(4, "ギルド加入申請を拒否", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(105, "ギルド脱退完了", FlowNode.PinTypes.Output, 105)]
  public class GuildConfirm : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400ABF3")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400ABF4")]
    private const int PIN_INPUT_START_REQUEST_ENTRY = 2;
    [Token(Token = "0x400ABF5")]
    private const int PIN_INPUT_START_GUILD_REQUEST_ENTRY_APPROVAL = 3;
    [Token(Token = "0x400ABF6")]
    private const int PIN_INPUT_START_GUILD_REQUEST_ENTRY_REJECT = 4;
    [Token(Token = "0x400ABF7")]
    private const int PIN_INPUT_START_GUILD_MEMBER_KICK = 5;
    [Token(Token = "0x400ABF8")]
    private const int PIN_INPUT_START_GUILD_LEAVE = 6;
    [Token(Token = "0x400ABF9")]
    private const int PIN_INPUT_START_GUILD_REQUEST_NG_ALL = 7;
    [Token(Token = "0x400ABFA")]
    private const int PIN_OUTPUT_END_REQUEST_ENTRY = 101;
    [Token(Token = "0x400ABFB")]
    private const int PIN_OUTPUT_END_GUILD_REQUEST_ENTRY_APPROVAL = 102;
    [Token(Token = "0x400ABFC")]
    private const int PIN_OUTPUT_END_GUILD_REQUEST_ENTRY_REJECT = 103;
    [Token(Token = "0x400ABFD")]
    private const int PIN_OUTPUT_END_GUILD_MEMBER_KICK = 104;
    [Token(Token = "0x400ABFE")]
    private const int PIN_OUTPUT_END_GUILD_LEAVE = 105;
    [Token(Token = "0x400ABFF")]
    private const int PIN_OUTPUT_END_GUILD_REQUEST_NG_ALL = 106;
    [Token(Token = "0x400AC00")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mEntryRequestRootObject;
    [Token(Token = "0x400AC01")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mEntryRequestObject;
    [Token(Token = "0x400AC02")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mEntryRequestFailedObject;
    [Token(Token = "0x400AC03")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mEntryRequestApprovalRootObject;
    [Token(Token = "0x400AC04")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mEntryRequestApprovalOKObject;
    [Token(Token = "0x400AC05")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mEntryRequestApprovalNGObject;
    [Token(Token = "0x400AC06")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mMemberKickObject;
    [Token(Token = "0x400AC07")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mLeaveObject;
    [Token(Token = "0x400AC08")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mEntryRequestNGAll;
    [Token(Token = "0x400AC09")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mLeaveConfirmObject;
    [Token(Token = "0x400AC0A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mDontLeaveMessageObject;
    [Token(Token = "0x400AC0B")]
    [FieldOffset(Offset = "0x0")]
    private static GuildConfirm mInstance;
    [Token(Token = "0x400AC0C")]
    [FieldOffset(Offset = "0x38")]
    private GuildData mTargetGuild;
    [Token(Token = "0x400AC0D")]
    [FieldOffset(Offset = "0x3C")]
    private GuildMemberData mTargetMember;
    [Token(Token = "0x400AC0E")]
    [FieldOffset(Offset = "0x40")]
    private List<GuildMemberData> mTargetEntryRequests;

    [Token(Token = "0x17001706")]
    public static GuildConfirm Instance
    {
      [Token(Token = "0x600A514"), Address(RVA = "0x6729C0", Offset = "0x6717C0", VA = "0x106729C0")] get
      {
        return (GuildConfirm) null;
      }
    }

    [Token(Token = "0x17001707")]
    public GuildData TargetGuild
    {
      [Token(Token = "0x600A515"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (GuildData) null;
      }
    }

    [Token(Token = "0x17001708")]
    public GuildMemberData TargetMember
    {
      [Token(Token = "0x600A516"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (GuildMemberData) null;
      }
    }

    [Token(Token = "0x17001709")]
    public List<GuildMemberData> TargetEntryRequests
    {
      [Token(Token = "0x600A517"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (List<GuildMemberData>) null;
      }
    }

    [Token(Token = "0x600A518")]
    [Address(RVA = "0x6719C0", Offset = "0x6707C0", VA = "0x106719C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A519")]
    [Address(RVA = "0x671900", Offset = "0x670700", VA = "0x10671900", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A51A")]
    [Address(RVA = "0x672070", Offset = "0x670E70", VA = "0x10672070")]
    private void Init()
    {
    }

    [Token(Token = "0x600A51B")]
    [Address(RVA = "0x6722B0", Offset = "0x6710B0", VA = "0x106722B0")]
    public static void SetConfirmType(GameObject svb_obj, GuildConfirm.eConfirmType type)
    {
    }

    [Token(Token = "0x600A51C")]
    [Address(RVA = "0x671EF0", Offset = "0x670CF0", VA = "0x10671EF0")]
    private GuildConfirm.eConfirmType GetConfirmType() => new GuildConfirm.eConfirmType();

    [Token(Token = "0x600A51D")]
    [Address(RVA = "0x6723C0", Offset = "0x6711C0", VA = "0x106723C0")]
    private void SetupUI(GuildConfirm.eConfirmType confirm_type)
    {
    }

    [Token(Token = "0x600A51E")]
    [Address(RVA = "0x671FB0", Offset = "0x670DB0", VA = "0x10671FB0")]
    private void HideAll()
    {
    }

    [Token(Token = "0x600A51F")]
    [Address(RVA = "0x671CB0", Offset = "0x670AB0", VA = "0x10671CB0")]
    private void Confirm_EntryRequest()
    {
    }

    [Token(Token = "0x600A520")]
    [Address(RVA = "0x671AE0", Offset = "0x6708E0", VA = "0x10671AE0")]
    private void Confirm_EntryRequestApprovalOK()
    {
    }

    [Token(Token = "0x600A521")]
    [Address(RVA = "0x671A00", Offset = "0x670800", VA = "0x10671A00")]
    private void Confirm_EntryRequestApprovalNG()
    {
    }

    [Token(Token = "0x600A522")]
    [Address(RVA = "0x671E30", Offset = "0x670C30", VA = "0x10671E30")]
    private void Confirm_MemberKick()
    {
    }

    [Token(Token = "0x600A523")]
    [Address(RVA = "0x671D40", Offset = "0x670B40", VA = "0x10671D40")]
    private void Confirm_Leave()
    {
    }

    [Token(Token = "0x600A524")]
    [Address(RVA = "0x671BD0", Offset = "0x6709D0", VA = "0x10671BD0")]
    private void Confirm_EntryRequestNGAll()
    {
    }

    [Token(Token = "0x600A525")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildConfirm()
    {
    }

    [Token(Token = "0x200255A")]
    public enum eConfirmType
    {
      [Token(Token = "0x400AC10")] NONE,
      [Token(Token = "0x400AC11")] ENTRY_REQUEST,
      [Token(Token = "0x400AC12")] ENTRY_REQUEST_APPROVAL_OK,
      [Token(Token = "0x400AC13")] ENTRY_REQUEST_APPROVAL_NG,
      [Token(Token = "0x400AC14")] MEMBER_KICK,
      [Token(Token = "0x400AC15")] LEAVE,
      [Token(Token = "0x400AC16")] ENTRY_REQUEST_NG_ALL,
    }
  }
}
