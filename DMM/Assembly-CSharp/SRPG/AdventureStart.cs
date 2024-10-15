// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FB3")]
  [AddComponentMenu("UI/Adventure/AdventureStart")]
  [FlowNode.Pin(11, "プッシュ通知チェッククリック", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "プッシュ通知判定", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "判定終了", FlowNode.PinTypes.Output, 101)]
  public class AdventureStart : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008642")]
    private const int PIN_INPUT_CHECK_TOGGLE = 1;
    [Token(Token = "0x4008643")]
    private const int PIN_INPUT_PUSH_TOGGLE_CLICK = 11;
    [Token(Token = "0x4008644")]
    private const int PIN_OUTPUT_CHECK_TOGGLE = 101;
    [Token(Token = "0x4008645")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text AdventureTimeText;
    [Token(Token = "0x4008646")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text AdventureStartDesc;
    [Token(Token = "0x4008647")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle LocalNotificationToggle;

    [Token(Token = "0x6008295")]
    [Address(RVA = "0x433080", Offset = "0x431E80", VA = "0x10433080", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008296")]
    [Address(RVA = "0x4334B0", Offset = "0x4322B0", VA = "0x104334B0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008297")]
    [Address(RVA = "0x4333D0", Offset = "0x4321D0", VA = "0x104333D0")]
    private void SetLocalNotification()
    {
    }

    [Token(Token = "0x6008298")]
    [Address(RVA = "0x4332A0", Offset = "0x4320A0", VA = "0x104332A0")]
    private void OnPushToggleClick()
    {
    }

    [Token(Token = "0x6008299")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureStart()
    {
    }
  }
}
