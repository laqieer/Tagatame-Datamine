// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidBossChallengedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D53")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidBossChallengedData : JSON_WorldRaidBossData
  {
    [Token(Token = "0x400E213")]
    [FieldOffset(Offset = "0x18")]
    public int challenged;

    [Token(Token = "0x600D338")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidBossChallengedData()
    {
    }
  }
}
