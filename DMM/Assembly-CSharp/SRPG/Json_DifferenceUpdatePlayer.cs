// Decompiled with JetBrains decompiler
// Type: SRPG.Json_DifferenceUpdatePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001034")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_DifferenceUpdatePlayer : Json_DifferenceUpdate
  {
    [Token(Token = "0x40039A3")]
    [FieldOffset(Offset = "0x24")]
    public Json_PlayerData player;

    [Token(Token = "0x600429A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_DifferenceUpdatePlayer()
    {
    }
  }
}
