// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillManipulateParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E43")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillManipulateParam
  {
    [Token(Token = "0x4007B28")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007B29")]
    [FieldOffset(Offset = "0xC")]
    public int manipulate;
    [Token(Token = "0x4007B2A")]
    [FieldOffset(Offset = "0x10")]
    public int type;
    [Token(Token = "0x4007B2B")]
    [FieldOffset(Offset = "0x14")]
    public int ini;
    [Token(Token = "0x4007B2C")]
    [FieldOffset(Offset = "0x18")]
    public int max;
    [Token(Token = "0x4007B2D")]
    [FieldOffset(Offset = "0x1C")]
    public int ratio;
    [Token(Token = "0x4007B2E")]
    [FieldOffset(Offset = "0x20")]
    public int dmg_type;
    [Token(Token = "0x4007B2F")]
    [FieldOffset(Offset = "0x24")]
    public int[] is_elems;
    [Token(Token = "0x4007B30")]
    [FieldOffset(Offset = "0x28")]
    public string effect;

    [Token(Token = "0x6007C1F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillManipulateParam()
    {
    }
  }
}
