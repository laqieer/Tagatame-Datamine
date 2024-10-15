// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusDraftDeckParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EB2")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusDraftDeckParam
  {
    [Token(Token = "0x4008093")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4008094")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4008095")]
    [FieldOffset(Offset = "0x10")]
    public int fix_secret;

    [Token(Token = "0x6007DCC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusDraftDeckParam()
    {
    }
  }
}
