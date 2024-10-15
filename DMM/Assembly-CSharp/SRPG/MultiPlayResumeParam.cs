// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayResumeParam
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
  [Token(Token = "0x2000DA2")]
  [MessagePackObject(true)]
  [Serializable]
  public class MultiPlayResumeParam
  {
    [Token(Token = "0x400272B")]
    [FieldOffset(Offset = "0x8")]
    public MultiPlayResumeUnitData[] unit;
    [Token(Token = "0x400272C")]
    [FieldOffset(Offset = "0xC")]
    public MultiPlayGimmickEventParam[] gimmick;
    [Token(Token = "0x400272D")]
    [FieldOffset(Offset = "0x10")]
    public MultiPlayTrickParam[] trick;
    [Token(Token = "0x400272E")]
    [FieldOffset(Offset = "0x14")]
    public uint[] rndseed;
    [Token(Token = "0x400272F")]
    [FieldOffset(Offset = "0x18")]
    public uint[] dmgrndseed;
    [Token(Token = "0x4002730")]
    [FieldOffset(Offset = "0x1C")]
    public uint damageseed;
    [Token(Token = "0x4002731")]
    [FieldOffset(Offset = "0x20")]
    public uint seed;
    [Token(Token = "0x4002732")]
    [FieldOffset(Offset = "0x24")]
    public int unitcastindex;
    [Token(Token = "0x4002733")]
    [FieldOffset(Offset = "0x28")]
    public int unitstartcount;
    [Token(Token = "0x4002734")]
    [FieldOffset(Offset = "0x2C")]
    public int treasurecount;
    [Token(Token = "0x4002735")]
    [FieldOffset(Offset = "0x30")]
    public uint versusturn;
    [Token(Token = "0x4002736")]
    [FieldOffset(Offset = "0x34")]
    public uint versusonceagainturn;
    [Token(Token = "0x4002737")]
    [FieldOffset(Offset = "0x38")]
    public int resumeID;
    [Token(Token = "0x4002738")]
    [FieldOffset(Offset = "0x3C")]
    public int[] otherresume;
    [Token(Token = "0x4002739")]
    [FieldOffset(Offset = "0x40")]
    public bool[] scr_ev_trg;
    [Token(Token = "0x400273A")]
    [FieldOffset(Offset = "0x44")]
    public int ctm;
    [Token(Token = "0x400273B")]
    [FieldOffset(Offset = "0x48")]
    public int ctt;
    [Token(Token = "0x400273C")]
    [FieldOffset(Offset = "0x4C")]
    public MultiPlayResumeParam.WeatherInfo wti;

    [Token(Token = "0x600373F")]
    [Address(RVA = "0x10A2610", Offset = "0x10A1410", VA = "0x110A2610")]
    public MultiPlayResumeParam()
    {
    }

    [Token(Token = "0x2000DA3")]
    [MessagePackObject(true)]
    [Serializable]
    public class WeatherInfo
    {
      [Token(Token = "0x400273D")]
      [FieldOffset(Offset = "0x8")]
      public string wid;
      [Token(Token = "0x400273E")]
      [FieldOffset(Offset = "0xC")]
      public int mun;
      [Token(Token = "0x400273F")]
      [FieldOffset(Offset = "0x10")]
      public int rnk;
      [Token(Token = "0x4002740")]
      [FieldOffset(Offset = "0x14")]
      public int rcp;
      [Token(Token = "0x4002741")]
      [FieldOffset(Offset = "0x18")]
      public int fcl;
      [Token(Token = "0x4002742")]
      [FieldOffset(Offset = "0x1C")]
      public int rwc;
      [Token(Token = "0x4002743")]
      [FieldOffset(Offset = "0x20")]
      public List<MultiPlayResumeParam.WeatherInfo> rwi;

      [Token(Token = "0x6003740")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public WeatherInfo()
      {
      }
    }
  }
}
