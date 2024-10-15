// Decompiled with JetBrains decompiler
// Type: SRPG.AutoRuneDisassemblyStateParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CCF")]
  [MessagePackObject(true)]
  public class AutoRuneDisassemblyStateParam
  {
    [Token(Token = "0x40070F3")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40070F4")]
    [FieldOffset(Offset = "0xC")]
    private AutoRuneDisassemblyStatesCondParam[] mStates;

    [Token(Token = "0x17000F70")]
    public string Iname
    {
      [Token(Token = "0x600767A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F71")]
    public AutoRuneDisassemblyStatesCondParam[] States
    {
      [Token(Token = "0x600767B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (AutoRuneDisassemblyStatesCondParam[]) null;
      }
    }

    [Token(Token = "0x600767C")]
    [Address(RVA = "0x38F790", Offset = "0x38E590", VA = "0x1038F790")]
    public bool Deserialize(JSON_AutoRuneDisassemblyStateParam json) => new bool();

    [Token(Token = "0x600767D")]
    [Address(RVA = "0x38F510", Offset = "0x38E310", VA = "0x1038F510")]
    public static bool Deserialize(
      ref List<AutoRuneDisassemblyStateParam> paramList,
      JSON_AutoRuneDisassemblyStateParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600767E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AutoRuneDisassemblyStateParam()
    {
    }
  }
}
