// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceQuestEventMapStarIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F5C")]
  [FlowNode.Pin(1, "Select", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Selected", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/Advance/AdvanceQuestEventMapStarIcon")]
  public class AdvanceQuestEventMapStarIcon : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008443")]
    private const int PIN_IN_SELECT = 1;
    [Token(Token = "0x4008444")]
    private const int PIN_OUT_SELECTED = 101;
    [Token(Token = "0x4008445")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private AdvanceQuestEventMap mParentMap;
    [Token(Token = "0x4008446")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray[] mTargetIconList;
    [Token(Token = "0x4008447")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mNeedStar;
    [Token(Token = "0x4008448")]
    [FieldOffset(Offset = "0x18")]
    private int mIndex;
    [Token(Token = "0x4008449")]
    [FieldOffset(Offset = "0x1C")]
    private AdvanceQuestEventMapStarIcon.EStartMissionState mState;

    [Token(Token = "0x17001272")]
    public int Index
    {
      [Token(Token = "0x60080BC"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001273")]
    public AdvanceQuestEventMapStarIcon.EStartMissionState State
    {
      [Token(Token = "0x60080BD"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new AdvanceQuestEventMapStarIcon.EStartMissionState();
      }
    }

    [Token(Token = "0x60080BE")]
    [Address(RVA = "0x416450", Offset = "0x415250", VA = "0x10416450")]
    public void Init(int count, int index, int totalStarNum, AdvanceStarRewardParam asr)
    {
    }

    [Token(Token = "0x60080BF")]
    [Address(RVA = "0x4163C0", Offset = "0x4151C0", VA = "0x104163C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60080C0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceQuestEventMapStarIcon()
    {
    }

    [Token(Token = "0x2001F5D")]
    public enum EStartMissionState
    {
      [Token(Token = "0x400844B")] NotReceive,
      [Token(Token = "0x400844C")] CanReceive,
      [Token(Token = "0x400844D")] Received,
    }
  }
}
