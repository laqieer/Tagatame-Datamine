// Decompiled with JetBrains decompiler
// Type: SRPG.GvGNPCPartyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B7D")]
  public class GvGNPCPartyParam : GvGMasterParam<JSON_GvGNPCPartyParam>
  {
    [Token(Token = "0x17000DA9")]
    public int Id
    {
      [Token(Token = "0x6007183"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007184"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000DAA")]
    public List<GvGNPCPartyDetailParam> Party
    {
      [Token(Token = "0x6007185"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GvGNPCPartyDetailParam>) null;
      }
      [Token(Token = "0x6007186"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6007187")]
    [Address(RVA = "0x372E30", Offset = "0x371C30", VA = "0x10372E30", Slot = "4")]
    public override bool Deserialize(JSON_GvGNPCPartyParam json) => new bool();

    [Token(Token = "0x6007188")]
    [Address(RVA = "0x372F70", Offset = "0x371D70", VA = "0x10372F70")]
    public GvGNPCPartyParam()
    {
    }
  }
}
