// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ResonanceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CBC")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ResonanceParam
  {
    [Token(Token = "0x40070BE")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40070BF")]
    [FieldOffset(Offset = "0xC")]
    public string recipe_iname;
    [Token(Token = "0x40070C0")]
    [FieldOffset(Offset = "0x10")]
    public string limit_rate;
    [Token(Token = "0x40070C1")]
    [FieldOffset(Offset = "0x14")]
    public JSON_ResonanceUnitParam[] units;

    [Token(Token = "0x6007642")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ResonanceParam()
    {
    }
  }
}
