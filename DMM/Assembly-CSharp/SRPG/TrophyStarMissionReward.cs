// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyStarMissionReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B75")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Trophy/TrophyStarMissionReward")]
  public class TrophyStarMissionReward : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D4CA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400D4CB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoBindObject;
    [Token(Token = "0x400D4CC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RewardWindowTrophy RewardWindowTrophyComponent;
    [Token(Token = "0x400D4CD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text TextBody;
    [Token(Token = "0x400D4CE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button ButtonReceive;
    [Token(Token = "0x400D4CF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text TextButton;
    [Token(Token = "0x400D4D0")]
    private const int PIN_IN_INIT = 1;

    [Token(Token = "0x600C716")]
    [Address(RVA = "0x904290", Offset = "0x903090", VA = "0x10904290")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C717")]
    [Address(RVA = "0x904300", Offset = "0x903100", VA = "0x10904300")]
    private void Init()
    {
    }

    [Token(Token = "0x600C718")]
    [Address(RVA = "0x904270", Offset = "0x903070", VA = "0x10904270", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C719")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TrophyStarMissionReward()
    {
    }
  }
}
