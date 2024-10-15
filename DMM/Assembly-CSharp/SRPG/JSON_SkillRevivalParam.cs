// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillRevivalParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E78")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillRevivalParam
  {
    [Token(Token = "0x4007E65")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007E66")]
    [FieldOffset(Offset = "0xC")]
    public string skill;
    [Token(Token = "0x4007E67")]
    [FieldOffset(Offset = "0x10")]
    public int ct;
    [Token(Token = "0x4007E68")]
    [FieldOffset(Offset = "0x14")]
    public int is_ct;
    [Token(Token = "0x4007E69")]
    [FieldOffset(Offset = "0x18")]
    public JSON_SkillRevivalBuffList[] buffs;

    [Token(Token = "0x6007CCB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillRevivalParam()
    {
    }
  }
}
