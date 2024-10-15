// Decompiled with JetBrains decompiler
// Type: SRPG.RuneMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CDD")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneMaterial
  {
    [Token(Token = "0x4007122")]
    [FieldOffset(Offset = "0x8")]
    public short rarity;
    [Token(Token = "0x4007123")]
    [FieldOffset(Offset = "0xC")]
    public short[] enhance_probability;
    [Token(Token = "0x4007124")]
    [FieldOffset(Offset = "0x10")]
    public RuneCost[] enh_cost;
    [Token(Token = "0x4007125")]
    [FieldOffset(Offset = "0x14")]
    public RuneCost[] evo_cost;
    [Token(Token = "0x4007126")]
    [FieldOffset(Offset = "0x18")]
    public int disassembly_zeny;
    [Token(Token = "0x4007127")]
    [FieldOffset(Offset = "0x1C")]
    public RuneDisassembly disassembly;
    [Token(Token = "0x4007128")]
    [FieldOffset(Offset = "0x20")]
    public int[] magnification;
    [Token(Token = "0x4007129")]
    [FieldOffset(Offset = "0x24")]
    public RuneCost[] reset_base_param_costs;
    [Token(Token = "0x400712A")]
    [FieldOffset(Offset = "0x28")]
    public RuneCost[] reset_evo_status_costs;
    [Token(Token = "0x400712B")]
    [FieldOffset(Offset = "0x2C")]
    public RuneCost[] param_enh_evo_costs;

    [Token(Token = "0x60076A0")]
    [Address(RVA = "0x39A6D0", Offset = "0x3994D0", VA = "0x1039A6D0")]
    public bool Deserialize(JSON_RuneMaterial json, MasterParam master = null) => new bool();

    [Token(Token = "0x60076A1")]
    [Address(RVA = "0x39AD60", Offset = "0x399B60", VA = "0x1039AD60")]
    public RuneMaterial()
    {
    }
  }
}
