// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RuneSetEff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CE2")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RuneSetEff
  {
    [Token(Token = "0x400713B")]
    [FieldOffset(Offset = "0x8")]
    public int seteff_type;
    [Token(Token = "0x400713C")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400713D")]
    [FieldOffset(Offset = "0x10")]
    public int icon_index;
    [Token(Token = "0x400713E")]
    [FieldOffset(Offset = "0x14")]
    public int cost;
    [Token(Token = "0x400713F")]
    [FieldOffset(Offset = "0x18")]
    public JSON_RuneSetEffState[] state;

    [Token(Token = "0x60076AC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RuneSetEff()
    {
    }
  }
}
