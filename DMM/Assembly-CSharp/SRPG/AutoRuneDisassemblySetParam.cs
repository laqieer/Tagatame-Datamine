// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRuneDisassemblySetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CCB")]
  [MessagePackObject(true)]
  public class AutoRuneDisassemblySetParam
  {
    [Token(Token = "0x40070E9")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40070EA")]
    [FieldOffset(Offset = "0xC")]
    private AutoRuneSettingCondParam[] mCnds;

    [Token(Token = "0x17000F6A")]
    public string Iname
    {
      [Token(Token = "0x600766D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F6B")]
    public AutoRuneSettingCondParam[] Cnds
    {
      [Token(Token = "0x600766E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (AutoRuneSettingCondParam[]) null;
      }
    }

    [Token(Token = "0x600766F")]
    [Address(RVA = "0x38F170", Offset = "0x38DF70", VA = "0x1038F170")]
    public bool Deserialize(JSON_AutoRuneDisassemblySetParam json) => new bool();

    [Token(Token = "0x6007670")]
    [Address(RVA = "0x38F2A0", Offset = "0x38E0A0", VA = "0x1038F2A0")]
    public static bool Deserialize(
      ref List<AutoRuneDisassemblySetParam> paramList,
      JSON_AutoRuneDisassemblySetParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007671")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRuneDisassemblySetParam()
    {
    }
  }
}
