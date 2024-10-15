// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideResetPotentialStatusCount
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
  [Token(Token = "0x2002A46")]
  public class RunePrideResetPotentialStatusCount : MonoBehaviour
  {
    [Token(Token = "0x400CDAD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle mToggleNoLimit;
    [Token(Token = "0x400CDAE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle mToggleCount;
    [Token(Token = "0x400CDAF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CountUpDownCommon mCountUpDownCommon;
    [Token(Token = "0x400CDB0")]
    [FieldOffset(Offset = "0x18")]
    private UnityAction mOnValueChanged;
    [Token(Token = "0x400CDB1")]
    private const string KEY_NAME = "RUNEPRIDESETTING.RESETCOUNT";
    [Token(Token = "0x400CDB2")]
    private const int MIN_COUNT = 1;
    [Token(Token = "0x400CDB3")]
    private const int MAX_COUNT = 99;

    [Token(Token = "0x600C0CB")]
    [Address(RVA = "0x893C70", Offset = "0x892A70", VA = "0x10893C70")]
    public int GetContinueCount() => new int();

    [Token(Token = "0x600C0CC")]
    [Address(RVA = "0x8940A0", Offset = "0x892EA0", VA = "0x108940A0")]
    public void Setup(UnityAction onValueChanged)
    {
    }

    [Token(Token = "0x600C0CD")]
    [Address(RVA = "0x893E50", Offset = "0x892C50", VA = "0x10893E50")]
    private void OnToggleNoLimitClick(bool isOn)
    {
    }

    [Token(Token = "0x600C0CE")]
    [Address(RVA = "0x85CE70", Offset = "0x85BC70", VA = "0x1085CE70")]
    private void OnToggleCountClick(bool isOn)
    {
    }

    [Token(Token = "0x600C0CF")]
    [Address(RVA = "0x85CE40", Offset = "0x85BC40", VA = "0x1085CE40")]
    private void OnCountDownValueChanged(int value)
    {
    }

    [Token(Token = "0x600C0D0")]
    [Address(RVA = "0x893F70", Offset = "0x892D70", VA = "0x10893F70")]
    public void SavePrefs()
    {
    }

    [Token(Token = "0x600C0D1")]
    [Address(RVA = "0x893D10", Offset = "0x892B10", VA = "0x10893D10")]
    public void LoadPrefs()
    {
    }

    [Token(Token = "0x600C0D2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePrideResetPotentialStatusCount()
    {
    }

    [Token(Token = "0x2002A47")]
    private class Config
    {
      [Token(Token = "0x400CDB4")]
      [FieldOffset(Offset = "0x8")]
      public int num;
      [Token(Token = "0x400CDB5")]
      [FieldOffset(Offset = "0xC")]
      public bool isOnNoLimit;
      [Token(Token = "0x400CDB6")]
      [FieldOffset(Offset = "0xD")]
      public bool isOnCount;

      [Token(Token = "0x600C0D3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Config()
      {
      }
    }
  }
}
