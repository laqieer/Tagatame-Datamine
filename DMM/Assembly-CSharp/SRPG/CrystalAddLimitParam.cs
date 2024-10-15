// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalAddLimitParam
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
  [Token(Token = "0x2001A84")]
  [MessagePackObject(true)]
  [Serializable]
  public class CrystalAddLimitParam
  {
    [Token(Token = "0x17000BF9")]
    public string Iname
    {
      [Token(Token = "0x6006CEE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006CEF"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000BFA")]
    public List<CrystalAddLimitStatus> Limits
    {
      [Token(Token = "0x6006CF0"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<CrystalAddLimitStatus>) null;
      }
      [Token(Token = "0x6006CF1"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6006CF2")]
    [Address(RVA = "0x357940", Offset = "0x356740", VA = "0x10357940")]
    public bool Deserialize(JSON_CrystalAddLimitParam json) => new bool();

    [Token(Token = "0x6006CF3")]
    [Address(RVA = "0x3576E0", Offset = "0x3564E0", VA = "0x103576E0")]
    public static void Deserialize(
      ref List<CrystalAddLimitParam> param,
      JSON_CrystalAddLimitParam[] json)
    {
    }

    [Token(Token = "0x6006CF4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalAddLimitParam()
    {
    }
  }
}
