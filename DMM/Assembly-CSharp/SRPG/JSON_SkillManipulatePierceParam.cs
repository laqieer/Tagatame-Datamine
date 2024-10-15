// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillManipulatePierceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E45")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillManipulatePierceParam
  {
    [Token(Token = "0x4007B3B")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007B3C")]
    [FieldOffset(Offset = "0xC")]
    public int manipulate;
    [Token(Token = "0x4007B3D")]
    [FieldOffset(Offset = "0x10")]
    public int dmg_type;
    [Token(Token = "0x4007B3E")]
    [FieldOffset(Offset = "0x14")]
    public int is_pierce;
    [Token(Token = "0x4007B3F")]
    [FieldOffset(Offset = "0x18")]
    public int is_break;
    [Token(Token = "0x4007B40")]
    [FieldOffset(Offset = "0x1C")]
    public int[] is_elems;
    [Token(Token = "0x4007B41")]
    [FieldOffset(Offset = "0x20")]
    public string effect;

    [Token(Token = "0x6007C31")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillManipulatePierceParam()
    {
    }
  }
}
