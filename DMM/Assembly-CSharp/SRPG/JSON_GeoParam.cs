// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GeoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B17")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GeoParam
  {
    [Token(Token = "0x4006741")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006742")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4006743")]
    [FieldOffset(Offset = "0x10")]
    public int cost;
    [Token(Token = "0x4006744")]
    [FieldOffset(Offset = "0x14")]
    public int stop;

    [Token(Token = "0x6006FD3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GeoParam()
    {
    }
  }
}
