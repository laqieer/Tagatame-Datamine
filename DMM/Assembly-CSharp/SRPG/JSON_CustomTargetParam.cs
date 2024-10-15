// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CustomTargetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DED")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CustomTargetParam
  {
    [Token(Token = "0x4007897")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007898")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007899")]
    [FieldOffset(Offset = "0x10")]
    public string[] units;
    [Token(Token = "0x400789A")]
    [FieldOffset(Offset = "0x14")]
    public string[] jobs;
    [Token(Token = "0x400789B")]
    [FieldOffset(Offset = "0x18")]
    public string[] unit_groups;
    [Token(Token = "0x400789C")]
    [FieldOffset(Offset = "0x1C")]
    public string[] job_groups;
    [Token(Token = "0x400789D")]
    [FieldOffset(Offset = "0x20")]
    public string[] concept_card_groups;
    [Token(Token = "0x400789E")]
    [FieldOffset(Offset = "0x24")]
    public string first_job;
    [Token(Token = "0x400789F")]
    [FieldOffset(Offset = "0x28")]
    public string second_job;
    [Token(Token = "0x40078A0")]
    [FieldOffset(Offset = "0x2C")]
    public string third_job;
    [Token(Token = "0x40078A1")]
    [FieldOffset(Offset = "0x30")]
    public int sex;
    [Token(Token = "0x40078A2")]
    [FieldOffset(Offset = "0x34")]
    public int birth_id;
    [Token(Token = "0x40078A3")]
    [FieldOffset(Offset = "0x38")]
    public int fire;
    [Token(Token = "0x40078A4")]
    [FieldOffset(Offset = "0x3C")]
    public int water;
    [Token(Token = "0x40078A5")]
    [FieldOffset(Offset = "0x40")]
    public int wind;
    [Token(Token = "0x40078A6")]
    [FieldOffset(Offset = "0x44")]
    public int thunder;
    [Token(Token = "0x40078A7")]
    [FieldOffset(Offset = "0x48")]
    public int shine;
    [Token(Token = "0x40078A8")]
    [FieldOffset(Offset = "0x4C")]
    public int dark;

    [Token(Token = "0x6007A6B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CustomTargetParam()
    {
    }
  }
}
