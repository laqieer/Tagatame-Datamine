// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraEnhanceMaxItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D64")]
  [MessagePackObject(true)]
  [Serializable]
  public class TobiraEnhanceMaxItemParam
  {
    [Token(Token = "0x1700100B")]
    public string ItemIname
    {
      [Token(Token = "0x6007852"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007853"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700100C")]
    public int NeedNum
    {
      [Token(Token = "0x6007854"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007855"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x1700100D")]
    public string InformationUrl
    {
      [Token(Token = "0x6007856"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007857"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x1700100E")]
    public string UnitGroupIname
    {
      [Token(Token = "0x6007858"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007859"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x600785A")]
    [Address(RVA = "0x3A43C0", Offset = "0x3A31C0", VA = "0x103A43C0")]
    public bool Deserialize(Json_TobiraEnhanceMaxItemParam json) => new bool();

    [Token(Token = "0x600785B")]
    [Address(RVA = "0x3A4280", Offset = "0x3A3080", VA = "0x103A4280")]
    public static void Deserialize(
      ref List<TobiraEnhanceMaxItemParam> param,
      Json_TobiraEnhanceMaxItemParam[] json)
    {
    }

    [Token(Token = "0x600785C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TobiraEnhanceMaxItemParam()
    {
    }
  }
}
