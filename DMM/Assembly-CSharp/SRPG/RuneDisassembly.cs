// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDisassembly
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
  [Token(Token = "0x2001CDE")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneDisassembly
  {
    [Token(Token = "0x400712C")]
    [FieldOffset(Offset = "0x8")]
    public List<RuneDisassembly.Materials> success;
    [Token(Token = "0x400712D")]
    [FieldOffset(Offset = "0xC")]
    public List<RuneDisassembly.Materials> great;
    [Token(Token = "0x400712E")]
    [FieldOffset(Offset = "0x10")]
    public List<RuneDisassembly.Materials> super;

    [Token(Token = "0x60076A2")]
    [Address(RVA = "0x3988B0", Offset = "0x3976B0", VA = "0x103988B0")]
    public bool Deserialize(JSON_RuneMaterial json, MasterParam master = null) => new bool();

    [Token(Token = "0x60076A3")]
    [Address(RVA = "0x398EA0", Offset = "0x397CA0", VA = "0x10398EA0")]
    public static void ResultCalc(
      List<BindRuneData> runes,
      ReqRuneDisassembly.Response.Result result,
      out Dictionary<string, RuneDisassembly.Materials> dict)
    {
    }

    [Token(Token = "0x60076A4")]
    [Address(RVA = "0x398D40", Offset = "0x397B40", VA = "0x10398D40")]
    private static void ResultAdd(
      RuneDisassembly.Materials material,
      Dictionary<string, RuneDisassembly.Materials> dict,
      float rate)
    {
    }

    [Token(Token = "0x60076A5")]
    [Address(RVA = "0x398CD0", Offset = "0x397AD0", VA = "0x10398CD0")]
    private static float GetEvoRate(RuneData _data) => new float();

    [Token(Token = "0x60076A6")]
    [Address(RVA = "0x399340", Offset = "0x398140", VA = "0x10399340")]
    public RuneDisassembly()
    {
    }

    [Token(Token = "0x2001CDF")]
    [MessagePackObject(true)]
    [Serializable]
    public class Materials
    {
      [Token(Token = "0x400712F")]
      [FieldOffset(Offset = "0x8")]
      public ItemParam item;
      [Token(Token = "0x4007130")]
      [FieldOffset(Offset = "0xC")]
      public short num;

      [Token(Token = "0x60076A7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Materials()
      {
      }
    }
  }
}
