// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideResetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D0E")]
  public class RunePrideResetParam
  {
    [Token(Token = "0x40071E3")]
    [FieldOffset(Offset = "0x8")]
    private DateTime mBeginAt;
    [Token(Token = "0x40071E4")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mEndAt;
    [Token(Token = "0x40071E5")]
    [FieldOffset(Offset = "0x18")]
    private List<RunePrideResetData> mResetList;

    [Token(Token = "0x17000FBD")]
    public DateTime BeginAt
    {
      [Token(Token = "0x600774F"), Address(RVA = "0x2ECBB0", Offset = "0x2EB9B0", VA = "0x102ECBB0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000FBE")]
    public DateTime EndAt
    {
      [Token(Token = "0x6007750"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000FBF")]
    public List<RunePrideResetData> ResetList
    {
      [Token(Token = "0x6007751"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<RunePrideResetData>) null;
      }
    }

    [Token(Token = "0x6007752")]
    [Address(RVA = "0x39D1B0", Offset = "0x39BFB0", VA = "0x1039D1B0")]
    public bool Deserialize(JSON_RunePrideResetParam _json) => new bool();

    [Token(Token = "0x6007753")]
    [Address(RVA = "0x39D060", Offset = "0x39BE60", VA = "0x1039D060")]
    public static bool Deserialize(
      ref List<RunePrideResetParam> paramList,
      JSON_RunePrideResetParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007754")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePrideResetParam()
    {
    }
  }
}
