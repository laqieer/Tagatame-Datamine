// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGNPCPartyDetailParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B7C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGNPCPartyDetailParam
  {
    [Token(Token = "0x40068BF")]
    [FieldOffset(Offset = "0x8")]
    public int order;
    [Token(Token = "0x40068C0")]
    [FieldOffset(Offset = "0xC")]
    public int unit1_id;
    [Token(Token = "0x40068C1")]
    [FieldOffset(Offset = "0x10")]
    public int unit2_id;
    [Token(Token = "0x40068C2")]
    [FieldOffset(Offset = "0x14")]
    public int unit3_id;

    [Token(Token = "0x6007182")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGNPCPartyDetailParam()
    {
    }
  }
}
