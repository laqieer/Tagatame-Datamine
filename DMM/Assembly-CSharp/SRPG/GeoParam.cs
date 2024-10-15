// Decompiled with JetBrains decompiler
// Type: SRPG.GeoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B18")]
  [MessagePackObject(true)]
  [Serializable]
  public class GeoParam
  {
    [Token(Token = "0x4006745")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006746")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4006747")]
    [FieldOffset(Offset = "0x10")]
    public OInt cost;
    [Token(Token = "0x4006748")]
    [FieldOffset(Offset = "0x24")]
    public OBool DisableStopped;

    [Token(Token = "0x6006FD4")]
    [Address(RVA = "0x36E110", Offset = "0x36CF10", VA = "0x1036E110")]
    public bool Deserialize(JSON_GeoParam json) => new bool();

    [Token(Token = "0x6006FD5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GeoParam()
    {
    }
  }
}
