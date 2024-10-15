// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiAreaRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200316B")]
  public class ReqMultiAreaRoom : WebAPI
  {
    [Token(Token = "0x600DE01")]
    [Address(RVA = "0xA9B1D0", Offset = "0xA99FD0", VA = "0x10A9B1D0")]
    public ReqMultiAreaRoom(
      string fuid,
      string[] iname,
      Vector2 location,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200316C")]
    public class Response
    {
      [Token(Token = "0x400ED36")]
      [FieldOffset(Offset = "0x8")]
      public MultiPlayAPIRoom[] rooms;

      [Token(Token = "0x600DE02")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
