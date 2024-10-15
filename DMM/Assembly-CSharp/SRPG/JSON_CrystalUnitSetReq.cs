// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalUnitSetReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002277")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalUnitSetReq
  {
    [Token(Token = "0x40098FF")]
    [FieldOffset(Offset = "0x8")]
    public long id;
    [Token(Token = "0x4009900")]
    [FieldOffset(Offset = "0x10")]
    public int slot;

    [Token(Token = "0x600933C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalUnitSetReq()
    {
    }
  }
}
