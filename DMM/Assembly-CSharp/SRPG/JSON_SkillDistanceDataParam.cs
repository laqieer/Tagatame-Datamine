// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SkillDistanceDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E39")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SkillDistanceDataParam
  {
    [Token(Token = "0x4007B06")]
    [FieldOffset(Offset = "0x8")]
    public int min;
    [Token(Token = "0x4007B07")]
    [FieldOffset(Offset = "0xC")]
    public int max;
    [Token(Token = "0x4007B08")]
    [FieldOffset(Offset = "0x10")]
    public int value;
    [Token(Token = "0x4007B09")]
    [FieldOffset(Offset = "0x14")]
    public int[] atk_types;
    [Token(Token = "0x4007B0A")]
    [FieldOffset(Offset = "0x18")]
    public int[] atk_dets;
    [Token(Token = "0x4007B0B")]
    [FieldOffset(Offset = "0x1C")]
    public int[] atk_elems;

    [Token(Token = "0x6007BF8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SkillDistanceDataParam()
    {
    }
  }
}
