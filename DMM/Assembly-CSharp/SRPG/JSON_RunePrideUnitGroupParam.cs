// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePrideUnitGroupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D0F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePrideUnitGroupParam
  {
    [Token(Token = "0x40071E6")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x40071E7")]
    [FieldOffset(Offset = "0xC")]
    public string[] units;

    [Token(Token = "0x6007755")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePrideUnitGroupParam()
    {
    }
  }
}
