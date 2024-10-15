// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillDistanceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E38")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillDistanceParam
  {
    [Token(Token = "0x4007B00")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007B01")]
    [FieldOffset(Offset = "0xC")]
    public int is_self;
    [Token(Token = "0x4007B02")]
    [FieldOffset(Offset = "0x10")]
    public int is_target;
    [Token(Token = "0x4007B03")]
    [FieldOffset(Offset = "0x14")]
    public int kind;
    [Token(Token = "0x4007B04")]
    [FieldOffset(Offset = "0x18")]
    public int turn;
    [Token(Token = "0x4007B05")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_SkillDistanceDataParam[] effects;

    [Token(Token = "0x6007BF7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillDistanceParam()
    {
    }
  }
}
