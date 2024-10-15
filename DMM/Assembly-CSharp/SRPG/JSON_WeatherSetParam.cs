// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WeatherSetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EF7")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WeatherSetParam
  {
    [Token(Token = "0x400825C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400825D")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400825E")]
    [FieldOffset(Offset = "0x10")]
    public string[] st_wth;
    [Token(Token = "0x400825F")]
    [FieldOffset(Offset = "0x14")]
    public int[] st_rate;
    [Token(Token = "0x4008260")]
    [FieldOffset(Offset = "0x18")]
    public int ch_cl_min;
    [Token(Token = "0x4008261")]
    [FieldOffset(Offset = "0x1C")]
    public int ch_cl_max;
    [Token(Token = "0x4008262")]
    [FieldOffset(Offset = "0x20")]
    public string[] ch_wth;
    [Token(Token = "0x4008263")]
    [FieldOffset(Offset = "0x24")]
    public int[] ch_rate;

    [Token(Token = "0x6007E93")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WeatherSetParam()
    {
    }
  }
}
