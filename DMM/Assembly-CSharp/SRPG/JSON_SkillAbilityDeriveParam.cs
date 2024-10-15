// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillAbilityDeriveParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E1C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillAbilityDeriveParam
  {
    [Token(Token = "0x4007A98")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007A99")]
    [FieldOffset(Offset = "0xC")]
    public int trig_type_1;
    [Token(Token = "0x4007A9A")]
    [FieldOffset(Offset = "0x10")]
    public string trig_iname_1;
    [Token(Token = "0x4007A9B")]
    [FieldOffset(Offset = "0x14")]
    public int trig_type_2;
    [Token(Token = "0x4007A9C")]
    [FieldOffset(Offset = "0x18")]
    public string trig_iname_2;
    [Token(Token = "0x4007A9D")]
    [FieldOffset(Offset = "0x1C")]
    public int trig_type_3;
    [Token(Token = "0x4007A9E")]
    [FieldOffset(Offset = "0x20")]
    public string trig_iname_3;
    [Token(Token = "0x4007A9F")]
    [FieldOffset(Offset = "0x24")]
    public string[] base_abils;
    [Token(Token = "0x4007AA0")]
    [FieldOffset(Offset = "0x28")]
    public string[] derive_abils;
    [Token(Token = "0x4007AA1")]
    [FieldOffset(Offset = "0x2C")]
    public string[] base_skills;
    [Token(Token = "0x4007AA2")]
    [FieldOffset(Offset = "0x30")]
    public string[] derive_skills;

    [Token(Token = "0x6007B8E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillAbilityDeriveParam()
    {
    }
  }
}
