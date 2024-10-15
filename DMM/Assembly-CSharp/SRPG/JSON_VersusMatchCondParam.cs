// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusMatchCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EC4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusMatchCondParam
  {
    [Token(Token = "0x400811F")]
    [FieldOffset(Offset = "0x8")]
    public int floor;
    [Token(Token = "0x4008120")]
    [FieldOffset(Offset = "0xC")]
    public int lvrang;
    [Token(Token = "0x4008121")]
    [FieldOffset(Offset = "0x10")]
    public int floorrange;

    [Token(Token = "0x6007DFC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusMatchCondParam()
    {
    }
  }
}
