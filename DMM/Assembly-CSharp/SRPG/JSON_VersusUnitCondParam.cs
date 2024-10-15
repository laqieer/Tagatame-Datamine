// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusUnitCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EEA")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusUnitCondParam
  {
    [Token(Token = "0x400820E")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x400820F")]
    [FieldOffset(Offset = "0xC")]
    public int mode;
    [Token(Token = "0x4008210")]
    [FieldOffset(Offset = "0x10")]
    public JSON_VersusUnitCondData[] condition;

    [Token(Token = "0x6007E5A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusUnitCondParam()
    {
    }
  }
}
