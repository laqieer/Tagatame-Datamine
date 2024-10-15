// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ResonanceLimitRateListParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CB8")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ResonanceLimitRateListParam
  {
    [Token(Token = "0x40070B3")]
    [FieldOffset(Offset = "0x8")]
    public int min_plus;
    [Token(Token = "0x40070B4")]
    [FieldOffset(Offset = "0xC")]
    public int max_plus;
    [Token(Token = "0x40070B5")]
    [FieldOffset(Offset = "0x10")]
    public string buff_rate;

    [Token(Token = "0x6007636")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ResonanceLimitRateListParam()
    {
    }
  }
}
