// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_FilterArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D27")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_FilterArtifactParam
  {
    [Token(Token = "0x4007250")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007251")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x4007252")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4007253")]
    [FieldOffset(Offset = "0x14")]
    public string sub_name;
    [Token(Token = "0x4007254")]
    [FieldOffset(Offset = "0x18")]
    public int category_type;
    [Token(Token = "0x4007255")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_FilterArtifactParam.Condition[] cnds;

    [Token(Token = "0x6007791")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_FilterArtifactParam()
    {
    }

    [Token(Token = "0x2001D28")]
    [MessagePackObject(true)]
    [Serializable]
    public class Condition
    {
      [Token(Token = "0x4007256")]
      [FieldOffset(Offset = "0x8")]
      public int filter_type;
      [Token(Token = "0x4007257")]
      [FieldOffset(Offset = "0xC")]
      public string cnds_name;
      [Token(Token = "0x4007258")]
      [FieldOffset(Offset = "0x10")]
      public string name;
      [Token(Token = "0x4007259")]
      [FieldOffset(Offset = "0x14")]
      public int rarity;
      [Token(Token = "0x400725A")]
      [FieldOffset(Offset = "0x18")]
      public int equip_type;
      [Token(Token = "0x400725B")]
      [FieldOffset(Offset = "0x1C")]
      public int is_have;
      [Token(Token = "0x400725C")]
      [FieldOffset(Offset = "0x20")]
      public string[] arms_type;
      [Token(Token = "0x400725D")]
      [FieldOffset(Offset = "0x24")]
      public int[] param_types;

      [Token(Token = "0x6007792")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Condition()
      {
      }
    }
  }
}
