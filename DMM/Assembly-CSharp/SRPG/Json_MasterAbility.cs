// Decompiled with JetBrains decompiler
// Type: SRPG.Json_MasterAbility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001006")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_MasterAbility
  {
    [Token(Token = "0x40038F7")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x40038F8")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x40038F9")]
    [FieldOffset(Offset = "0x14")]
    public int exp;

    [Token(Token = "0x600426A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_MasterAbility()
    {
    }
  }
}
