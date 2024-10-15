// Decompiled with JetBrains decompiler
// Type: SRPG.RuneLotteryBaseStatePack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CE9")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneLotteryBaseStatePack
  {
    [Token(Token = "0x4007152")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007153")]
    [FieldOffset(Offset = "0xC")]
    public JSON_RuneLotteryStatePack[] lottery_state;

    [Token(Token = "0x60076C5")]
    [Address(RVA = "0x362350", Offset = "0x361150", VA = "0x10362350")]
    public bool Deserialize(JSON_RuneLotteryBaseStatePack json) => new bool();

    [Token(Token = "0x17000F78")]
    public List<RuneLotteryEvoState> RuneEvoStates
    {
      [Token(Token = "0x60076C6"), Address(RVA = "0x399410", Offset = "0x398210", VA = "0x10399410")] get
      {
        return (List<RuneLotteryEvoState>) null;
      }
    }

    [Token(Token = "0x60076C7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneLotteryBaseStatePack()
    {
    }
  }
}
