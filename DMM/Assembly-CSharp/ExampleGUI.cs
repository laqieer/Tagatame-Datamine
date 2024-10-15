// Decompiled with JetBrains decompiler
// Type: ExampleGUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using com.adjust.sdk;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000003")]
public class ExampleGUI : MonoBehaviour
{
  [Token(Token = "0x4000003")]
  [FieldOffset(Offset = "0xC")]
  private int numberOfButtons;
  [Token(Token = "0x4000004")]
  [FieldOffset(Offset = "0x10")]
  private bool isEnabled;
  [Token(Token = "0x4000005")]
  [FieldOffset(Offset = "0x11")]
  private bool showPopUp;
  [Token(Token = "0x4000006")]
  [FieldOffset(Offset = "0x14")]
  private string txtSetEnabled;
  [Token(Token = "0x4000007")]
  [FieldOffset(Offset = "0x18")]
  private string txtManualLaunch;
  [Token(Token = "0x4000008")]
  [FieldOffset(Offset = "0x1C")]
  private string txtSetOfflineMode;

  [Token(Token = "0x6000007")]
  [Address(RVA = "0x2C38B0", Offset = "0x2C26B0", VA = "0x102C38B0")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x6000008")]
  [Address(RVA = "0x2C4840", Offset = "0x2C3640", VA = "0x102C4840")]
  private void ShowGUI(int windowID)
  {
  }

  [Token(Token = "0x6000009")]
  [Address(RVA = "0x2C3840", Offset = "0x2C2640", VA = "0x102C3840")]
  public void HandleGooglePlayId(string adId)
  {
  }

  [Token(Token = "0x600000A")]
  [Address(RVA = "0x2C3050", Offset = "0x2C1E50", VA = "0x102C3050")]
  public void AttributionChangedCallback(AdjustAttribution attributionData)
  {
  }

  [Token(Token = "0x600000B")]
  [Address(RVA = "0x2C3630", Offset = "0x2C2430", VA = "0x102C3630")]
  public void EventSuccessCallback(AdjustEventSuccess eventSuccessData)
  {
  }

  [Token(Token = "0x600000C")]
  [Address(RVA = "0x2C33B0", Offset = "0x2C21B0", VA = "0x102C33B0")]
  public void EventFailureCallback(AdjustEventFailure eventFailureData)
  {
  }

  [Token(Token = "0x600000D")]
  [Address(RVA = "0x2C46C0", Offset = "0x2C34C0", VA = "0x102C46C0")]
  public void SessionSuccessCallback(AdjustSessionSuccess sessionSuccessData)
  {
  }

  [Token(Token = "0x600000E")]
  [Address(RVA = "0x2C44D0", Offset = "0x2C32D0", VA = "0x102C44D0")]
  public void SessionFailureCallback(AdjustSessionFailure sessionFailureData)
  {
  }

  [Token(Token = "0x600000F")]
  [Address(RVA = "0x2C32E0", Offset = "0x2C20E0", VA = "0x102C32E0")]
  private void DeferredDeeplinkCallback(string deeplinkURL)
  {
  }

  [Token(Token = "0x6000010")]
  [Address(RVA = "0x2C4990", Offset = "0x2C3790", VA = "0x102C4990")]
  public ExampleGUI()
  {
  }
}
