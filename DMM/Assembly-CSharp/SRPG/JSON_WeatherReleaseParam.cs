﻿// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WeatherReleaseParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EF4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WeatherReleaseParam
  {
    [Token(Token = "0x4008253")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4008254")]
    [FieldOffset(Offset = "0xC")]
    public int is_map_weather_del;
    [Token(Token = "0x4008255")]
    [FieldOffset(Offset = "0x10")]
    public JSON_WeatherReleaseInameParam[] target_inames;

    [Token(Token = "0x6007E8B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WeatherReleaseParam()
    {
    }
  }
}