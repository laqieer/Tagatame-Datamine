// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillAdditionalParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E27")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillAdditionalParam
  {
    [Token(Token = "0x4007AC6")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007AC7")]
    [FieldOffset(Offset = "0xC")]
    public int cond;
    [Token(Token = "0x4007AC8")]
    [FieldOffset(Offset = "0x10")]
    public string skill;
    [Token(Token = "0x4007AC9")]
    [FieldOffset(Offset = "0x14")]
    public int is_target_self;
    [Token(Token = "0x4007ACA")]
    [FieldOffset(Offset = "0x18")]
    public int is_hide;

    [Token(Token = "0x6007BC9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillAdditionalParam()
    {
    }
  }
}
