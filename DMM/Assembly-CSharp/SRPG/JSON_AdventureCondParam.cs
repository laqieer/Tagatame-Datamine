// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdventureCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001971")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdventureCondParam
  {
    [Token(Token = "0x4005CAC")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005CAD")]
    [FieldOffset(Offset = "0xC")]
    public JSON_AdventureCondParam.Cond[] conds;

    [Token(Token = "0x60067C6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdventureCondParam()
    {
    }

    [Token(Token = "0x2001972")]
    [MessagePackObject(true)]
    [Serializable]
    public class Cond
    {
      [Token(Token = "0x4005CAE")]
      [FieldOffset(Offset = "0x8")]
      public int cond_type;
      [Token(Token = "0x4005CAF")]
      [FieldOffset(Offset = "0xC")]
      public string cond_text;
      [Token(Token = "0x4005CB0")]
      [FieldOffset(Offset = "0x10")]
      public int level;
      [Token(Token = "0x4005CB1")]
      [FieldOffset(Offset = "0x14")]
      public string unit_group;
      [Token(Token = "0x4005CB2")]
      [FieldOffset(Offset = "0x18")]
      public int[] elems;
      [Token(Token = "0x4005CB3")]
      [FieldOffset(Offset = "0x1C")]
      public int[] births;
      [Token(Token = "0x4005CB4")]
      [FieldOffset(Offset = "0x20")]
      public int gender;
      [Token(Token = "0x4005CB5")]
      [FieldOffset(Offset = "0x24")]
      public int cp_min;
      [Token(Token = "0x4005CB6")]
      [FieldOffset(Offset = "0x28")]
      public int all_cp_min;

      [Token(Token = "0x60067C7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Cond()
      {
      }
    }
  }
}
