// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BtlPointResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002812")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_BtlPointResult
  {
    [Token(Token = "0x400BEF6")]
    [FieldOffset(Offset = "0x8")]
    public Json_BtlPointMission[] missions;
    [Token(Token = "0x400BEF7")]
    [FieldOffset(Offset = "0xC")]
    public int action_num;
    [Token(Token = "0x400BEF8")]
    [FieldOffset(Offset = "0x10")]
    public int dead_num;

    [Token(Token = "0x600B509")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BtlPointResult()
    {
    }
  }
}
