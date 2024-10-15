// Decompiled with JetBrains decompiler
// Type: SRPG.WeatherInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C6B")]
  [AddComponentMenu("Battle/BattleUI/WeatherInfo")]
  public class WeatherInfo : MonoBehaviour
  {
    [Token(Token = "0x4002182")]
    [FieldOffset(Offset = "0xC")]
    public GameObject GoWeatherInfo;
    [Token(Token = "0x4002183")]
    [FieldOffset(Offset = "0x10")]
    private WeatherData mCurrentWeaterData;

    [Token(Token = "0x170002ED")]
    public WeatherData CurrentWeaterData
    {
      [Token(Token = "0x60030F5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (WeatherData) null;
      }
    }

    [Token(Token = "0x60030F6")]
    [Address(RVA = "0x102F0E0", Offset = "0x102DEE0", VA = "0x1102F0E0")]
    private void Start()
    {
    }

    [Token(Token = "0x60030F7")]
    [Address(RVA = "0x102EF50", Offset = "0x102DD50", VA = "0x1102EF50")]
    public void Refresh(WeatherData wd)
    {
    }

    [Token(Token = "0x60030F8")]
    [Address(RVA = "0x102F090", Offset = "0x102DE90", VA = "0x1102F090")]
    public void SetActive(bool _active)
    {
    }

    [Token(Token = "0x60030F9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WeatherInfo()
    {
    }
  }
}
