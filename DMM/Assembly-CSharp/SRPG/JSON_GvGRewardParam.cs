// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B85")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGRewardParam : JSON_GvGMasterParam
  {
    [Token(Token = "0x40068F9")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x40068FA")]
    [FieldOffset(Offset = "0xC")]
    public JSON_GvGRewardDetailParam[] rewards;

    [Token(Token = "0x60071D2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGRewardParam()
    {
    }
  }
}
