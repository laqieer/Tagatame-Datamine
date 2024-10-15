// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidBossReqData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D55")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidBossReqData : JSON_WorldRaidBossData
  {
    [Token(Token = "0x400E215")]
    [FieldOffset(Offset = "0x18")]
    public string worldraid_iname;
    [Token(Token = "0x400E216")]
    [FieldOffset(Offset = "0x1C")]
    public int lap;

    [Token(Token = "0x600D33A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidBossReqData()
    {
    }
  }
}
