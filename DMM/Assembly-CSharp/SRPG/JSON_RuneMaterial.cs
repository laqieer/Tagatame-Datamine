// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RuneMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CDB")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RuneMaterial
  {
    [Token(Token = "0x4007112")]
    [FieldOffset(Offset = "0x8")]
    public int rarity;
    [Token(Token = "0x4007113")]
    [FieldOffset(Offset = "0xC")]
    public string[] enh_cost;
    [Token(Token = "0x4007114")]
    [FieldOffset(Offset = "0x10")]
    public string[] evo_cost;
    [Token(Token = "0x4007115")]
    [FieldOffset(Offset = "0x14")]
    public int disassembly_zeny;
    [Token(Token = "0x4007116")]
    [FieldOffset(Offset = "0x18")]
    public JSON_RuneDisassembly[] disassembly;
    [Token(Token = "0x4007117")]
    [FieldOffset(Offset = "0x1C")]
    public int[] enhance_probability;
    [Token(Token = "0x4007118")]
    [FieldOffset(Offset = "0x20")]
    public int[] magnification;
    [Token(Token = "0x4007119")]
    [FieldOffset(Offset = "0x24")]
    public string[] reset_base_param_costs;
    [Token(Token = "0x400711A")]
    [FieldOffset(Offset = "0x28")]
    public string[] reset_evo_status_costs;
    [Token(Token = "0x400711B")]
    [FieldOffset(Offset = "0x2C")]
    public string[] param_enh_evo_costs;

    [Token(Token = "0x600769E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RuneMaterial()
    {
    }
  }
}
