// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidLastAccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D5A")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidLastAccess
  {
    [Token(Token = "0x400E228")]
    [FieldOffset(Offset = "0x8")]
    public int lap;
    [Token(Token = "0x400E229")]
    [FieldOffset(Offset = "0xC")]
    public JSON_WorldRaidBossChallengedData[] bosses;

    [Token(Token = "0x600D33F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidLastAccess()
    {
    }
  }
}
