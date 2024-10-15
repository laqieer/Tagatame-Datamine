// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapPartySubCT
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C01")]
  [Serializable]
  public class JSON_MapPartySubCT
  {
    [Token(Token = "0x4001EB1")]
    [FieldOffset(Offset = "0x8")]
    public int ct_calc;
    [Token(Token = "0x4001EB2")]
    [FieldOffset(Offset = "0xC")]
    public int ct_val;

    [Token(Token = "0x600300C")]
    [Address(RVA = "0xFE4AF0", Offset = "0xFE38F0", VA = "0x10FE4AF0")]
    public void CopyTo(JSON_MapPartySubCT dst)
    {
    }

    [Token(Token = "0x600300D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MapPartySubCT()
    {
    }
  }
}
