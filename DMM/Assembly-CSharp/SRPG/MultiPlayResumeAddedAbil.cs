// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayResumeAddedAbil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D98")]
  [MessagePackObject(true)]
  [Serializable]
  public class MultiPlayResumeAddedAbil
  {
    [Token(Token = "0x40026CA")]
    [FieldOffset(Offset = "0x8")]
    public string aid;
    [Token(Token = "0x40026CB")]
    [FieldOffset(Offset = "0xC")]
    public int exp;
    [Token(Token = "0x40026CC")]
    [FieldOffset(Offset = "0x10")]
    public bool nct;

    [Token(Token = "0x6003735")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiPlayResumeAddedAbil()
    {
    }
  }
}
