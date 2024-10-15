// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBossStageInfo
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
  [Token(Token = "0x20028D9")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Raid/RaidBossStageInfo")]
  [FlowNode.Pin(102, "Finish Reward", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Next Reward", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(2, "Check Reward", FlowNode.PinTypes.Input, 2)]
  public class RaidBossStageInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C421")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400C422")]
    public const int PIN_INPUT_CHECK_REWARD = 2;
    [Token(Token = "0x400C423")]
    public const int PIN_OUTPUT_GET_REWARD = 101;
    [Token(Token = "0x400C424")]
    public const int PIN_OUTPUT_FINISH_REWARD = 102;
    [Token(Token = "0x400C425")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mClearIcon;
    [Token(Token = "0x400C426")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RawImage_Transparent mRaidImage;
    [Token(Token = "0x400C427")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRescueListGO;
    [Token(Token = "0x400C428")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform mRescueListTransform;
    [Token(Token = "0x400C429")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mRescueListItem;
    [Token(Token = "0x400C42A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRemainTimeGO;
    [Token(Token = "0x400C42B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mChallengeButton;
    [Token(Token = "0x400C42C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mScheduleClose;
    [Token(Token = "0x400C42D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text mRemainTimeText;
    [Token(Token = "0x400C42E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mMemberCurrent;
    [Token(Token = "0x400C42F")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mMemberMax;
    [Token(Token = "0x400C430")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> mSOSMembers;

    [Token(Token = "0x600B8AA")]
    [Address(RVA = "0x7FB660", Offset = "0x7FA460", VA = "0x107FB660")]
    private void Update()
    {
    }

    [Token(Token = "0x600B8AB")]
    [Address(RVA = "0x7FA590", Offset = "0x7F9390", VA = "0x107FA590", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B8AC")]
    [Address(RVA = "0x7FA680", Offset = "0x7F9480", VA = "0x107FA680")]
    private void Init()
    {
    }

    [Token(Token = "0x600B8AD")]
    [Address(RVA = "0x7FB0E0", Offset = "0x7F9EE0", VA = "0x107FB0E0")]
    private void UpdateRemainTime()
    {
    }

    [Token(Token = "0x600B8AE")]
    [Address(RVA = "0x7FB500", Offset = "0x7FA300", VA = "0x107FB500")]
    private void UpdateScheduleClose()
    {
    }

    [Token(Token = "0x600B8AF")]
    [Address(RVA = "0x7FB680", Offset = "0x7FA480", VA = "0x107FB680")]
    public RaidBossStageInfo()
    {
    }
  }
}
