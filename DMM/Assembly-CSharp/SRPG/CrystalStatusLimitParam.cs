// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalStatusLimitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AA6")]
  [MessagePackObject(true)]
  [Serializable]
  public class CrystalStatusLimitParam
  {
    [Token(Token = "0x17000C4C")]
    public ParamTypes Type
    {
      [Token(Token = "0x6006DDF"), Address(RVA = "0x357AF0", Offset = "0x3568F0", VA = "0x10357AF0")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x6006DE0"), Address(RVA = "0x357B10", Offset = "0x356910", VA = "0x10357B10")] private set
      {
      }
    }

    [Token(Token = "0x17000C4D")]
    public int Value
    {
      [Token(Token = "0x6006DE1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006DE2"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x6006DE3")]
    [Address(RVA = "0x35CBB0", Offset = "0x35B9B0", VA = "0x1035CBB0")]
    public bool Deserialize(JSON_CrystalStatusLimitParam json) => new bool();

    [Token(Token = "0x6006DE4")]
    [Address(RVA = "0x35CAA0", Offset = "0x35B8A0", VA = "0x1035CAA0")]
    public static void Deserialize(
      ref List<CrystalStatusLimitParam> param,
      JSON_CrystalStatusLimitParam[] json)
    {
    }

    [Token(Token = "0x6006DE5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalStatusLimitParam()
    {
    }
  }
}
