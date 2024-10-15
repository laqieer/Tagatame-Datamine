// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRuneDisassemblyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CC8")]
  [MessagePackObject(true)]
  public class AutoRuneDisassemblyParam
  {
    [Token(Token = "0x40070DF")]
    [FieldOffset(Offset = "0x8")]
    private int mRarity;
    [Token(Token = "0x40070E0")]
    [FieldOffset(Offset = "0xC")]
    private string mRarity_name;
    [Token(Token = "0x40070E1")]
    [FieldOffset(Offset = "0x10")]
    private string set_eff;
    [Token(Token = "0x40070E2")]
    [FieldOffset(Offset = "0x14")]
    private string rune_type;

    [Token(Token = "0x17000F66")]
    public int Rarity
    {
      [Token(Token = "0x6007664"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F67")]
    public string Rarity_name
    {
      [Token(Token = "0x6007665"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F68")]
    public string Set_eff
    {
      [Token(Token = "0x6007666"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F69")]
    public string Rune_type
    {
      [Token(Token = "0x6007667"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007668")]
    [Address(RVA = "0x38F120", Offset = "0x38DF20", VA = "0x1038F120")]
    public bool Deserialize(JSON_AutoRuneDisassemblyParam json) => new bool();

    [Token(Token = "0x6007669")]
    [Address(RVA = "0x38EFA0", Offset = "0x38DDA0", VA = "0x1038EFA0")]
    public static bool Deserialize(
      ref List<AutoRuneDisassemblyParam> paramList,
      JSON_AutoRuneDisassemblyParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600766A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRuneDisassemblyParam()
    {
    }
  }
}
