// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeCountResetConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200211E")]
  [FlowNode.Pin(0, "close", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("UI/ChallengeCountResetConfirmWindow")]
  public class ChallengeCountResetConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008F9B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text ResetMessageText;
    [Token(Token = "0x4008F9C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ResetCostItem;
    [Token(Token = "0x4008F9D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text ResetCostNum;
    [Token(Token = "0x4008F9E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text ResetCostConsume;
    [Token(Token = "0x4008F9F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text ResetCountCurrent;
    [Token(Token = "0x4008FA0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text ResetCountLimit;
    [Token(Token = "0x4008FA1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button DecideButton;
    [Token(Token = "0x4008FA2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button CancelButton;
    [Token(Token = "0x4008FA3")]
    [FieldOffset(Offset = "0x2C")]
    public ChallengeCountResetConfirmWindow.ChallengeCountResetEvent DecideEvent;
    [Token(Token = "0x4008FA4")]
    [FieldOffset(Offset = "0x30")]
    public ChallengeCountResetConfirmWindow.ChallengeCountResetEvent CancelEvent;

    [Token(Token = "0x6008ABE")]
    [Address(RVA = "0x4E53C0", Offset = "0x4E41C0", VA = "0x104E53C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008ABF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008AC0")]
    [Address(RVA = "0x4E5520", Offset = "0x4E4320", VA = "0x104E5520")]
    private void OnClickDecide()
    {
    }

    [Token(Token = "0x6008AC1")]
    [Address(RVA = "0x4E54F0", Offset = "0x4E42F0", VA = "0x104E54F0")]
    private void OnClickCancel()
    {
    }

    [Token(Token = "0x6008AC2")]
    [Address(RVA = "0x4E5560", Offset = "0x4E4360", VA = "0x104E5560")]
    public bool Setup(
      ItemData item,
      int use_num,
      int reset_num,
      int reset_max,
      ChallengeCountResetConfirmWindow.ChallengeCountResetEvent okEvent,
      ChallengeCountResetConfirmWindow.ChallengeCountResetEvent cancelEvent)
    {
      return new bool();
    }

    [Token(Token = "0x6008AC3")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008AC4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChallengeCountResetConfirmWindow()
    {
    }

    [Token(Token = "0x200211F")]
    public delegate void ChallengeCountResetEvent(GameObject dialog);
  }
}
