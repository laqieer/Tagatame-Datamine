// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CB6")]
  [MessagePackObject(true)]
  public class ResonanceCondParam
  {
    [Token(Token = "0x40070AE")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40070AF")]
    [FieldOffset(Offset = "0xC")]
    private int mUnitLv;
    [Token(Token = "0x40070B0")]
    [FieldOffset(Offset = "0x10")]
    private ResonanceJobParam[] mJobs;

    [Token(Token = "0x17000F53")]
    public string Iname
    {
      [Token(Token = "0x600762F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F54")]
    public int UnitLv
    {
      [Token(Token = "0x6007630"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F55")]
    public ResonanceJobParam[] Jobs
    {
      [Token(Token = "0x6007631"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ResonanceJobParam[]) null;
      }
    }

    [Token(Token = "0x6007632")]
    [Address(RVA = "0x397390", Offset = "0x396190", VA = "0x10397390")]
    public bool Deserialize(JSON_ResonanceCondParam json) => new bool();

    [Token(Token = "0x6007633")]
    [Address(RVA = "0x397110", Offset = "0x395F10", VA = "0x10397110")]
    public static bool Deserialize(
      ref List<ResonanceCondParam> paramList,
      JSON_ResonanceCondParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007634")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceCondParam()
    {
    }
  }
}
