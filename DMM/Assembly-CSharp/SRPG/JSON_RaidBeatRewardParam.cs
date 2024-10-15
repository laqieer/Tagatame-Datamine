// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidBeatRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C69")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RaidBeatRewardParam : JSON_RaidMasterParam
  {
    [Token(Token = "0x4006F9E")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006F9F")]
    [FieldOffset(Offset = "0xC")]
    public JSON_RaidBeatRewardDataParam[] rewards;

    [Token(Token = "0x6007540")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidBeatRewardParam()
    {
    }
  }
}
