// Decompiled with JetBrains decompiler
// Type: SRPG.WeatherSetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EF8")]
  public class WeatherSetParam
  {
    [Token(Token = "0x4008264")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4008265")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4008266")]
    [FieldOffset(Offset = "0x10")]
    private List<string> mStartWeatherIdLists;
    [Token(Token = "0x4008267")]
    [FieldOffset(Offset = "0x14")]
    private List<int> mStartWeatherRateLists;
    [Token(Token = "0x4008268")]
    [FieldOffset(Offset = "0x18")]
    private int mChangeClockMin;
    [Token(Token = "0x4008269")]
    [FieldOffset(Offset = "0x1C")]
    private int mChangeClockMax;
    [Token(Token = "0x400826A")]
    [FieldOffset(Offset = "0x20")]
    private List<string> mChangeWeatherIdLists;
    [Token(Token = "0x400826B")]
    [FieldOffset(Offset = "0x24")]
    private List<int> mChangeWeatherRateLists;

    [Token(Token = "0x170011F8")]
    public string Iname
    {
      [Token(Token = "0x6007E94"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011F9")]
    public string Name
    {
      [Token(Token = "0x6007E95"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011FA")]
    public List<string> StartWeatherIdLists
    {
      [Token(Token = "0x6007E96"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x170011FB")]
    public List<int> StartWeatherRateLists
    {
      [Token(Token = "0x6007E97"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x170011FC")]
    public int ChangeClockMin
    {
      [Token(Token = "0x6007E98"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011FD")]
    public int ChangeClockMax
    {
      [Token(Token = "0x6007E99"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011FE")]
    public List<string> ChangeWeatherIdLists
    {
      [Token(Token = "0x6007E9A"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x170011FF")]
    public List<int> ChangeWeatherRateLists
    {
      [Token(Token = "0x6007E9B"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x6007E9C")]
    [Address(RVA = "0x412600", Offset = "0x411400", VA = "0x10412600")]
    public void Deserialize(JSON_WeatherSetParam json)
    {
    }

    [Token(Token = "0x6007E9D")]
    [Address(RVA = "0x412B70", Offset = "0x411970", VA = "0x10412B70")]
    public string GetStartWeather(RandXorshift rand = null) => (string) null;

    [Token(Token = "0x6007E9E")]
    [Address(RVA = "0x412A20", Offset = "0x411820", VA = "0x10412A20")]
    public string GetChangeWeather(RandXorshift rand = null) => (string) null;

    [Token(Token = "0x6007E9F")]
    [Address(RVA = "0x412B20", Offset = "0x411920", VA = "0x10412B20")]
    public int GetNextChangeClock(int now_clock, RandXorshift rand = null) => new int();

    [Token(Token = "0x6007EA0")]
    [Address(RVA = "0x412C70", Offset = "0x411A70", VA = "0x10412C70")]
    public WeatherSetParam()
    {
    }
  }
}
