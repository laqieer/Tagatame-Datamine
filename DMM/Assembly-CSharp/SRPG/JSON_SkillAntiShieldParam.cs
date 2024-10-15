// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillAntiShieldParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E2B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillAntiShieldParam
  {
    [Token(Token = "0x4007AD8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007AD9")]
    [FieldOffset(Offset = "0xC")]
    public int is_ignore;
    [Token(Token = "0x4007ADA")]
    [FieldOffset(Offset = "0x10")]
    public short ignore_rate_ini;
    [Token(Token = "0x4007ADB")]
    [FieldOffset(Offset = "0x12")]
    public short ignore_rate_max;
    [Token(Token = "0x4007ADC")]
    [FieldOffset(Offset = "0x14")]
    public int is_destroy;
    [Token(Token = "0x4007ADD")]
    [FieldOffset(Offset = "0x18")]
    public short destroy_rate_ini;
    [Token(Token = "0x4007ADE")]
    [FieldOffset(Offset = "0x1A")]
    public short destroy_rate_max;

    [Token(Token = "0x6007BD3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillAntiShieldParam()
    {
    }
  }
}
