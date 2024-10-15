// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BondMissionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002095")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_BondMissionData
  {
    [Token(Token = "0x4008C7E")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4008C7F")]
    [FieldOffset(Offset = "0xC")]
    public int is_received;

    [Token(Token = "0x60087A3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BondMissionData()
    {
    }
  }
}
