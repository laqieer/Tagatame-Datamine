// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusUnitCondData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EE9")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusUnitCondData
  {
    [Token(Token = "0x4008209")]
    [FieldOffset(Offset = "0x8")]
    public string[] group;
    [Token(Token = "0x400820A")]
    [FieldOffset(Offset = "0xC")]
    public int[] sex;
    [Token(Token = "0x400820B")]
    [FieldOffset(Offset = "0x10")]
    public int[] elem;
    [Token(Token = "0x400820C")]
    [FieldOffset(Offset = "0x14")]
    public int[] birth;
    [Token(Token = "0x400820D")]
    [FieldOffset(Offset = "0x18")]
    public string[] unit;

    [Token(Token = "0x6007E59")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusUnitCondData()
    {
    }
  }
}
