// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceLimitRateParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CB9")]
  [MessagePackObject(true)]
  public class ResonanceLimitRateParam
  {
    [Token(Token = "0x40070B6")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40070B7")]
    [FieldOffset(Offset = "0xC")]
    private ResonanceLimitRateListParam[] mRate;

    [Token(Token = "0x17000F56")]
    public string Iname
    {
      [Token(Token = "0x6007637"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F57")]
    public ResonanceLimitRateListParam[] Rate
    {
      [Token(Token = "0x6007638"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ResonanceLimitRateListParam[]) null;
      }
    }

    [Token(Token = "0x6007639")]
    [Address(RVA = "0x397510", Offset = "0x396310", VA = "0x10397510")]
    public bool Deserialize(JSON_ResonanceLimitRateParam json) => new bool();

    [Token(Token = "0x600763A")]
    [Address(RVA = "0x397660", Offset = "0x396460", VA = "0x10397660")]
    public static bool Deserialize(
      ref List<ResonanceLimitRateParam> paramList,
      JSON_ResonanceLimitRateParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600763B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceLimitRateParam()
    {
    }
  }
}
