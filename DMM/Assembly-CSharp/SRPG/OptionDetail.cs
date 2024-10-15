// Decompiled with JetBrains decompiler
// Type: SRPG.OptionDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027C2")]
  [FlowNode.Pin(11, "ToggleChargeDisp", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/OptionDetail")]
  public class OptionDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BC47")]
    [FieldOffset(Offset = "0xC")]
    public Slider SoundVolume;
    [Token(Token = "0x400BC48")]
    [FieldOffset(Offset = "0x10")]
    public Slider MusicVolume;
    [Token(Token = "0x400BC49")]
    [FieldOffset(Offset = "0x14")]
    public Slider VoiceVolume;
    [Token(Token = "0x400BC4A")]
    [FieldOffset(Offset = "0x18")]
    public LText ChargeDispText;
    [Token(Token = "0x400BC4B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button battleSpeedButton;
    [Token(Token = "0x400BC4C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private LText battleSpeedText;
    [Token(Token = "0x400BC4D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject battleSpeedLockObj;

    [Token(Token = "0x600B29C")]
    [Address(RVA = "0x7AA990", Offset = "0x7A9790", VA = "0x107AA990", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B29D")]
    [Address(RVA = "0x7AACF0", Offset = "0x7A9AF0", VA = "0x107AACF0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B29E")]
    [Address(RVA = "0x7AB440", Offset = "0x7AA240", VA = "0x107AB440")]
    private void UpdateChargeDispText(bool is_disp)
    {
    }

    [Token(Token = "0x600B29F")]
    [Address(RVA = "0x7AAAA0", Offset = "0x7A98A0", VA = "0x107AAAA0")]
    private void OnClickBattleSpeedButton()
    {
    }

    [Token(Token = "0x600B2A0")]
    [Address(RVA = "0x7AB330", Offset = "0x7AA130", VA = "0x107AB330")]
    private void UpdateBattleSpeedText()
    {
    }

    [Token(Token = "0x600B2A1")]
    [Address(RVA = "0x7AAB20", Offset = "0x7A9920", VA = "0x107AAB20")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B2A2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public OptionDetail()
    {
    }
  }
}
