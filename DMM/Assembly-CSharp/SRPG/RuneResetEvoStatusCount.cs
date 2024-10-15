// Decompiled with JetBrains decompiler
// Type: SRPG.RuneResetEvoStatusCount
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
  [Token(Token = "0x20029CC")]
  public class RuneResetEvoStatusCount : MonoBehaviour
  {
    [Token(Token = "0x400CAED")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle mToggleNoLimit;
    [Token(Token = "0x400CAEE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle mToggleCount;
    [Token(Token = "0x400CAEF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CountUpDownCommon mCountUpDownCommon;
    [Token(Token = "0x400CAF0")]
    [FieldOffset(Offset = "0x18")]
    private UnityAction mOnValueChanged;
    [Token(Token = "0x400CAF1")]
    private const string KEY_NAME = "RUNESETTING.RESETCOUNT";
    [Token(Token = "0x400CAF2")]
    private const int MIN_COUNT = 1;
    [Token(Token = "0x400CAF3")]
    private const int MAX_COUNT = 99;

    [Token(Token = "0x600BE5E")]
    [Address(RVA = "0x85CC60", Offset = "0x85BA60", VA = "0x1085CC60")]
    public int GetContinueCount() => new int();

    [Token(Token = "0x600BE5F")]
    [Address(RVA = "0x85D140", Offset = "0x85BF40", VA = "0x1085D140")]
    public void Setup(UnityAction onValueChanged)
    {
    }

    [Token(Token = "0x600BE60")]
    [Address(RVA = "0x85CEF0", Offset = "0x85BCF0", VA = "0x1085CEF0")]
    private void OnToggleNoLimitClick(bool isOn)
    {
    }

    [Token(Token = "0x600BE61")]
    [Address(RVA = "0x85CE70", Offset = "0x85BC70", VA = "0x1085CE70")]
    private void OnToggleCountClick(bool isOn)
    {
    }

    [Token(Token = "0x600BE62")]
    [Address(RVA = "0x85CE40", Offset = "0x85BC40", VA = "0x1085CE40")]
    private void OnCountDownValueChanged(int value)
    {
    }

    [Token(Token = "0x600BE63")]
    [Address(RVA = "0x85D010", Offset = "0x85BE10", VA = "0x1085D010")]
    public void SavePrefs()
    {
    }

    [Token(Token = "0x600BE64")]
    [Address(RVA = "0x85CD00", Offset = "0x85BB00", VA = "0x1085CD00")]
    private void LoadPrefs()
    {
    }

    [Token(Token = "0x600BE65")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneResetEvoStatusCount()
    {
    }

    [Token(Token = "0x20029CD")]
    private class Config
    {
      [Token(Token = "0x400CAF4")]
      [FieldOffset(Offset = "0x8")]
      public int num;
      [Token(Token = "0x400CAF5")]
      [FieldOffset(Offset = "0xC")]
      public bool isOnNoLimit;
      [Token(Token = "0x400CAF6")]
      [FieldOffset(Offset = "0xD")]
      public bool isOnCount;

      [Token(Token = "0x600BE66")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Config()
      {
      }
    }
  }
}
