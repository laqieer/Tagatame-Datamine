// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillReactionCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E73")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillReactionCondParam
  {
    [Token(Token = "0x4007E53")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007E54")]
    [FieldOffset(Offset = "0xC")]
    public JSON_TargetSkillInameParam[] skill_ids;
    [Token(Token = "0x4007E55")]
    [FieldOffset(Offset = "0x10")]
    public int[] vecs;
    [Token(Token = "0x4007E56")]
    [FieldOffset(Offset = "0x14")]
    public int[] skill_elems;
    [Token(Token = "0x4007E57")]
    [FieldOffset(Offset = "0x18")]
    public int[] unit_elems;
    [Token(Token = "0x4007E58")]
    [FieldOffset(Offset = "0x1C")]
    public int base_dir;

    [Token(Token = "0x6007CBD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillReactionCondParam()
    {
    }
  }
}
