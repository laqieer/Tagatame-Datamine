// Decompiled with JetBrains decompiler
// Type: SRPG.BondBadgeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020A1")]
  [Serializable]
  public class BondBadgeData
  {
    [Token(Token = "0x4008C97")]
    [FieldOffset(Offset = "0x8")]
    public string BondGroupIname;
    [Token(Token = "0x4008C98")]
    [FieldOffset(Offset = "0xC")]
    public bool IsOpenAnime;
    [Token(Token = "0x4008C99")]
    [FieldOffset(Offset = "0xD")]
    public bool IsTop;
    [Token(Token = "0x4008C9A")]
    [FieldOffset(Offset = "0x10")]
    public long LastDate;

    [Token(Token = "0x60087D1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondBadgeData()
    {
    }
  }
}
