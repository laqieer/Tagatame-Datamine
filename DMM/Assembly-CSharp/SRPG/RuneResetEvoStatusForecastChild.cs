// Decompiled with JetBrains decompiler
// Type: SRPG.RuneResetEvoStatusForecastChild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029D1")]
  public class RuneResetEvoStatusForecastChild : MonoBehaviour
  {
    [Token(Token = "0x400CB04")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle mCheckBox;
    [Token(Token = "0x400CB05")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mLockImage;
    [Token(Token = "0x400CB06")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mDisableImage;
    [Token(Token = "0x400CB07")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StatusList mStatusBefore;
    [Token(Token = "0x400CB08")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private StatusList mStatusAfter;
    [Token(Token = "0x400CB09")]
    [FieldOffset(Offset = "0x20")]
    private BaseStatus m_BeforeAddStatus;
    [Token(Token = "0x400CB0A")]
    [FieldOffset(Offset = "0x24")]
    private BaseStatus m_BeforeScaleStatus;
    [Token(Token = "0x400CB0B")]
    [FieldOffset(Offset = "0x28")]
    private BaseStatus m_AfterAddStatus;
    [Token(Token = "0x400CB0C")]
    [FieldOffset(Offset = "0x2C")]
    private BaseStatus m_AfterScaleStatus;
    [Token(Token = "0x400CB0D")]
    [FieldOffset(Offset = "0x30")]
    private bool m_IsLock;
    [Token(Token = "0x400CB0E")]
    [FieldOffset(Offset = "0x34")]
    private RuneStatusGaugeSelector mSelector;

    [Token(Token = "0x170019AF")]
    public bool IsToggleOn
    {
      [Token(Token = "0x600BE76"), Address(RVA = "0x85DAB0", Offset = "0x85C8B0", VA = "0x1085DAB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170019B0")]
    public bool IsLock
    {
      [Token(Token = "0x600BE77"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BE78")]
    [Address(RVA = "0x85D8D0", Offset = "0x85C6D0", VA = "0x1085D8D0")]
    public void Setup(
      RuneStatusGaugeSelector selector,
      UnityAction<bool> onValueChanged,
      bool isLock,
      BaseStatus before_add = null,
      BaseStatus before_scale = null,
      BaseStatus after_add = null,
      BaseStatus after_scale = null)
    {
    }

    [Token(Token = "0x600BE79")]
    [Address(RVA = "0x85D7B0", Offset = "0x85C5B0", VA = "0x1085D7B0")]
    public void SetBeforeBaseStatus(BaseStatus before_add, BaseStatus before_scale)
    {
    }

    [Token(Token = "0x600BE7A")]
    [Address(RVA = "0x85D860", Offset = "0x85C660", VA = "0x1085D860")]
    public void SetToggle(bool isOn)
    {
    }

    [Token(Token = "0x600BE7B")]
    [Address(RVA = "0x85D6C0", Offset = "0x85C4C0", VA = "0x1085D6C0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BE7C")]
    [Address(RVA = "0x85D5A0", Offset = "0x85C3A0", VA = "0x1085D5A0")]
    public bool IsAfterParamLower() => new bool();

    [Token(Token = "0x600BE7D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneResetEvoStatusForecastChild()
    {
    }
  }
}
